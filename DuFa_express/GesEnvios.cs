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
    public partial class GesEnvios : Form
    {
        public GesEnvios()
        {
            InitializeComponent();
        }

        private void GesEnvios_Load(object sender, EventArgs e)
        {
            ListarEstados();
            GetTabEnviosDGV();
            cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
            OpcPerfil();
        }

        private void txtNumGuia_Enter(object sender, EventArgs e)
        {
            if (txtNumGuia.Text == "*N° GUIA")
            {
                txtNumGuia.Text = "";
            }            
        }

        private void txtNumGuia_Leave(object sender, EventArgs e)
        {
            if (txtNumGuia.Text == "")
            {
                txtNumGuia.Text = "*N° GUIA";
            }
        }

        private void OpcPerfil()
        {
            if (Cache.IdTipoPer == "1")
            {
                btnSolAnulacion.Visible = false;
            }
            else if (Cache.IdTipoPer == "5")
            {
                btnAnularEnvio.Visible = false;
            }
        }

        private void GetTabEnviosDGV()
        {
            UsuarioDAL_C enviar = new UsuarioDAL_C();
            dgvGesEnvios.DataSource = enviar.getTabEnviosDGV();
        }

        private void ListarEstados()
        {
            UsuarioDAL_C enviar = new UsuarioDAL_C();
            cmbEstadoEnvio.DataSource = enviar.ListarEstados();
            cmbEstadoEnvio.DisplayMember = "DescEstado";
            cmbEstadoEnvio.ValueMember = "IdEstado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumGuia.Text != "*N° GUIA")
            {
                UsuarioDAL_C enviar = new UsuarioDAL_C();
                DatosClient datos = new DatosClient();
                datos.NumIdUsu = txtNumGuia.Text;
                dgvGesEnvios.DataSource = enviar.getTabEnviosGuiaDGV(datos);                

                if (dgvGesEnvios.Rows.Count < 1)
                {
                    lblMsgError.Visible = true;
                    MensajeError("No se encontraron registros con ese numero de guia.");
                }
                else
                    lblMsgError.Visible = false;

            }
            else if (cmbEstadoEnvio.Text != "*ESTADO ENVÍO")
            {
                UsuarioDAL_C enviar = new UsuarioDAL_C();
                DatosClient datos = new DatosClient();
                datos.IdEstadoEnvio = Convert.ToString(cmbEstadoEnvio.SelectedValue);
                dgvGesEnvios.DataSource = enviar.getTabEnviosEstadoDGV(datos);

                if (dgvGesEnvios.Rows.Count < 1)
                {
                    lblMsgError.Visible = true;
                    MensajeError("No se encontraron registros con ese estado.");
                }
                else
                    lblMsgError.Visible = false;
            }
            else
            {
                GetTabEnviosDGV();
                lblMsgError.Visible = false;
            }
            cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
        }

        private void btnAnularEnvio_Click(object sender, EventArgs e)
        {
            if (dgvGesEnvios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la anulación del envío
                    DatosClient enviar = new DatosClient();
                    enviar.IdEstadoEnvio = "6";
                    enviar.IdEnvioGuia = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["N° GUIA"].Value);
                    int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                    MensajeError("El envío ha sido anulado exitosamente.");
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
