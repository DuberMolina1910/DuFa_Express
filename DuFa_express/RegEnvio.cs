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
    public partial class RegEnvio : Form
    {
        public RegEnvio()
        {
            InitializeComponent();
        }

        private void RegEnvio_Load(object sender, EventArgs e)
        {
            ListarTipoPerRegEnvios();
        }

        private void lblNomUsu_Click(object sender, EventArgs e)
        {

        }

        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }

        /*Buscar usuario en el formulario de registro de envios*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumId.Text != "")
            {
                DatosClient enviar = new DatosClient();
                enviar.NumIdUsu = txtNumId.Text;
                enviar.IdTipoPer = Convert.ToString(cmbTipoPer.SelectedValue);

                int res = UsuarioDAL_C.CosultarUsuarios(enviar);

                if (res > 0)
                {
                    InfoUsuariosRegEnvios();
                    lblNomUsu.Visible = true;
                    lblCorreoUsu.Visible = true;
                    lblTelUsu.Visible = true;
                    lblDirUsu.Visible = true;

                    MensajeError("Consulta Exitosa.");

                    cmbTipoUsu.Enabled = true;
                    dtpFechEnvio.Enabled = true;
                    cmbIdSucOri.Enabled = true;
                    cmbIdSucDes.Enabled = true;
                    txtNumIdDes.Enabled = true;
                    txtNomDes.Enabled = true;
                    txtTelDes.Enabled = true;
                    txtDirDes.Enabled = true;
                    txtDetEnvio.Enabled = true;
                    btnConfirmar.Enabled = true;
                }
                else
                    MensajeError("Usuario no existe.");
            }
            else
            {
                MensajeError("Digite un numero de identificación.");
            }
        }

        /*Listar los tipos de perfiles en el formulario de registrar envios*/
        public void ListarTipoPerRegEnvios()
        {
            UsuarioDAL_C TipoPer = new UsuarioDAL_C();
            cmbTipoPer.DataSource = TipoPer.ListarTipoPer();
            cmbTipoPer.DisplayMember = "DescTipoPer";
            cmbTipoPer.ValueMember = "IdTipoPer";
        }

        private void InfoUsuariosRegEnvios()
        {
            lblNomUsu.Text = CacheRegEnvio.NomUsu;
            lblCorreoUsu.Text = CacheRegEnvio.CorreoUsu;
            lblTelUsu.Text = CacheRegEnvio.TelUsu;
            lblDirUsu.Text = CacheRegEnvio.DirDomUsu;
        }
    }
}
