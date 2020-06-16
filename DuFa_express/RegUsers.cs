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
    public partial class RegUsers : Form
    {
        public RegUsers()
        {
            InitializeComponent();
        }

        private void RegUsers_Load(object sender, EventArgs e)
        {
            ListarTipoId();
            ListarTipoPer();
            ListarCiudades();
            ListarSucursalesbyCiudad();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtBxNombreClient.Text != "" && TxtBxIdClient.Text != "" && MskTxtbxFechaNacClient.Text != "" && TxtBxTelefonoClient.Text != "" && TxtBxEmailClient.Text != "" && TxtBxDirDomClient.Text != "" && TxtBxContrasenaClient.Text != "" && TxtBxConfirContraClient.Text != "")
            {
                if (TxtBxContrasenaClient.Text == TxtBxConfirContraClient.Text)
                {
                    DatosClient enviar = new DatosClient();
                    enviar.NomUsu = TxtBxNombreClient.Text;
                    enviar.IdTipoId = Convert.ToString(CmbBoxIdTipoId.SelectedValue);
                    enviar.IdTipoPer = Convert.ToString(cmbTipoUsu.SelectedValue);
                    enviar.CiudadUsu = Convert.ToString(cmbCiudad.SelectedValue);
                    enviar.SucursalOperarios = Convert.ToString(cmbSucOper.SelectedValue);
                    enviar.NumIdUsu = TxtBxIdClient.Text;
                    enviar.FechNacUsu = MskTxtbxFechaNacClient.Text;
                    enviar.TelUsu = TxtBxTelefonoClient.Text;
                    enviar.CorreoUsu = TxtBxEmailClient.Text;
                    enviar.DirDomUsu = TxtBxDirDomClient.Text;
                    enviar.Contrasena = TxtBxContrasenaClient.Text;

                    int resultado = UsuarioDAL_C.RegistrarUsu(enviar);

                    if (resultado > 0)
                    {
                        MensajeError("Datos guardados correctamente.");
                        TxtBxNombreClient.Clear();
                        TxtBxIdClient.Clear();
                        MskTxtbxFechaNacClient.Clear();
                        TxtBxTelefonoClient.Clear();
                        TxtBxEmailClient.Clear();
                        TxtBxDirDomClient.Clear();
                        TxtBxContrasenaClient.Clear();
                        TxtBxConfirContraClient.Clear();
                    }
                    else
                    {
                        MensajeError("No se guardaron los datos.");
                    }
                }            
            }
            else
                MensajeError("Asegurese de llenar todos los campos.");
        }

        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }

        public void ListarTipoId()
        {
            UsuarioDAL_C TipoId = new UsuarioDAL_C();
            CmbBoxIdTipoId.DataSource = TipoId.ListarIdTipoId();
            CmbBoxIdTipoId.DisplayMember = "NomTipoId";
            CmbBoxIdTipoId.ValueMember = "IdTipoId";
        }

        public void ListarTipoPer()
        {
            UsuarioDAL_C TipoPer = new UsuarioDAL_C();
            cmbTipoUsu.DataSource = TipoPer.ListarTipoPer();
            cmbTipoUsu.DisplayMember = "DescTipoPer";
            cmbTipoUsu.ValueMember = "IdTipoPer";
        }

        public void ListarCiudades()
        {
            UsuarioDAL_C Ciudad = new UsuarioDAL_C();
            cmbCiudad.DataSource = Ciudad.ListarCiudades();
            cmbCiudad.DisplayMember = "NomCiudad";
            cmbCiudad.ValueMember = "IdCiudad";
        }

        public void ListarSucursales()
        {
            UsuarioDAL_C Sucu = new UsuarioDAL_C();

            cmbSucOper.DataSource = Sucu.ListarSucursales();
            cmbSucOper.DisplayMember = "NomSucursal";
            cmbSucOper.ValueMember = "IdSucursal";

            
        }

        public void ListarSucursalesbyCiudad()
        {
            UsuarioDAL_C SucXCiu = new UsuarioDAL_C();

            cmbSucOper.DataSource = SucXCiu.ListarSucursalesbyCiudad(Convert.ToInt32(cmbSucOper.SelectedValue));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
