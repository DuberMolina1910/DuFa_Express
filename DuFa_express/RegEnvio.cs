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
            ListarSucursales();
        }
        private void timerFechaEnvio_Tick(object sender, EventArgs e)
        {
            lblShowFechaEnvio.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
                enviar.IdTipoPer = "5";

                int res = UsuarioDAL_C.CosultarUsuarios(enviar);

                if (res > 0)
                {
                    InfoUsuariosRegEnvios();
                    lblNomUsu.Visible = true;
                    lblCorreoUsu.Visible = true;
                    lblTelUsu.Visible = true;
                    lblDirUsu.Visible = true;

                    CalcValor calcval = new CalcValor();
                    calcval.ShowDialog();

                    cmbIdSucOri.Enabled = true;
                    cmbIdSucDes.Enabled = true;
                    txtNumIdDes.Enabled = true;
                    txtNomDes.Enabled = true;
                    txtTelDes.Enabled = true;
                    txtDirDes.Enabled = true;
                    txtDetEnvio.Enabled = true;
                    btnConfirmar.Enabled = true;
                    lblValEnvio.Text = "COP $ " + CacheRegEnvio.ValTotalEnvio;
                }
                else
                    MensajeError("Usuario no existe.");
            }
            else
            {
                MensajeError("Digite un numero de identificación.");
            }
        }

        private void InfoUsuariosRegEnvios()
        {
            lblNomUsu.Text = CacheRegEnvio.NomUsu;
            lblCorreoUsu.Text = CacheRegEnvio.CorreoUsu;
            lblTelUsu.Text = CacheRegEnvio.TelUsu;
            lblDirUsu.Text = CacheRegEnvio.DirDomUsu;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNumId.Text != "" && lblShowFechaEnvio.Text != "" && txtNumIdDes.Text != "" && txtNomDes.Text != "" && txtTelDes.Text != "" && txtDirDes.Text != "" && txtDetEnvio.Text != "")
            {
                DatosClient enviar = new DatosClient();
                enviar.NumIdUsu = txtNumId.Text;
                enviar.ValTotalEnvio = CacheRegEnvio.ValTotalEnvio;
                enviar.IdEstadoEnvio = "1";
                enviar.FechEnvio = lblShowFechaEnvio.Text;
                enviar.IdTipoPer = "5";
                enviar.SucursalOrigen = Convert.ToString(cmbIdSucOri.SelectedValue);
                enviar.SucursalDestino = Convert.ToString(cmbIdSucDes.SelectedValue);
                enviar.IdDestinatario = txtNumIdDes.Text;
                enviar.NomDestinatario = txtNomDes.Text;
                enviar.TelDestinatario = txtTelDes.Text;
                enviar.DirDestinatario = txtDirDes.Text;
                enviar.DetEnvio = txtDetEnvio.Text;

                int res = UsuarioDAL_C.RegistrarEnvio(enviar);

                if (res > 0)
                {
                    MensajeError("Datos guardados correctamente.");
                    txtNumId.Enabled = false;
                    cmbIdSucOri.Enabled = false;
                    cmbIdSucDes.Enabled = false;
                    txtNumIdDes.Enabled = false;
                    txtNomDes.Enabled = false;
                    txtTelDes.Enabled = false;
                    txtDirDes.Enabled = false;
                    txtDetEnvio.Enabled = false;
                    btnConfirmar.Enabled = false;
                    btnNuevoReg.Enabled = true;

                    UsuarioDAL_C.CrearNumeroGuia();
                    txtNumGuia.Text = Convert.ToString(CacheRegEnvio.IdEnvioGuia);
                }
            }
            else
                MensajeError("Por favor llene los campos .");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListarSucursales()
        {
            UsuarioDAL_C SucuOrigen = new UsuarioDAL_C();
            cmbIdSucOri.DataSource = SucuOrigen.ListarSucursales();
            cmbIdSucOri.DisplayMember = "NomSucursal";
            cmbIdSucOri.ValueMember = "IdSucursal";

            UsuarioDAL_C SucuDestino = new UsuarioDAL_C();
            cmbIdSucDes.DataSource = SucuDestino.ListarSucursales();
            cmbIdSucDes.DisplayMember = "NomSucursal";
            cmbIdSucDes.ValueMember = "IdSucursal";
        }

        private void btnNuevoReg_Click(object sender, EventArgs e)
        {
            txtNumGuia.Clear();
            txtNumId.Clear();
            txtNumId.Enabled = true;
            btnConfirmar.Enabled = false;
            btnNuevoReg.Enabled = false;
            CacheRegEnvio.ValTotalEnvio = Convert.ToString(0);
            lblValEnvio.Text = "COP $0";
            txtNumIdDes.Clear();
            txtNomDes.Clear();
            txtTelDes.Clear();
            txtDirDes.Clear();
            txtDetEnvio.Clear();
        }

        private void txtDetEnvio_Enter(object sender, EventArgs e)
        {
            if (txtDetEnvio.Text == "Por favor haga una breve descripción del envío")
            {
                txtDetEnvio.Text = "";
            }
        }

        private void txtDetEnvio_Leave(object sender, EventArgs e)
        {
            if (txtDetEnvio.Text == "")
            {
                txtDetEnvio.Text = "Por favor haga una breve descripción del envío";
            }
        }
    }
}
