using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuFa_express
{
    public partial class SolicitudesAnulacion : Form
    {
        public SolicitudesAnulacion()
        {
            InitializeComponent();
        }

        private void SolicitudesAnulacion_Load(object sender, EventArgs e)
        {
            dgvSolAnul();
        }
        private void dgvSolAnul()
        {
            UsuarioDAL_C envios = new UsuarioDAL_C();
            dgvSolicAnulacion.DataSource = envios.getTabEnviosEstadoSolAnulDGV();
        }

        private void btnAnularEnvio_Click(object sender, EventArgs e)
        {
            if (dgvSolicAnulacion.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la anulación del envío
                    DatosClient enviar = new DatosClient();
                    enviar.IdEstadoEnvio = "6";
                    enviar.IdEnvioGuia = Convert.ToString(dgvSolicAnulacion.CurrentRow.Cells["N° GUIA"].Value);
                    int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                    MensajeError("El envío ha sido anulado exitosamente.");
                    dgvSolAnul();
                }
            }
            else
                MensajeError("Seleccione el envío a anular.");
        }
        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }
    }
}
