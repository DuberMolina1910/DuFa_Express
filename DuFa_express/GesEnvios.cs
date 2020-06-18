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

        private void GetTabEnviosDGV()
        {
            UsuarioDAL_C enviar = new UsuarioDAL_C();
            DatosClient datos = new DatosClient();
            dgvGesEnvios.DataSource = enviar.getTabEnviosDGV(datos);
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
                dgvGesEnvios.DataSource = enviar.getTabEnviosDGV(datos);

            }
            else
            {
                GetTabEnviosDGV();
            }
        }
    }
}
