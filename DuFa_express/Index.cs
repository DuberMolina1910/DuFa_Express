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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ListarTipoPer();
        }

        private void TxtNumID_Enter(object sender, EventArgs e)
        {
            if (TxtNumID.Text == "*N° IDENTIFICACIÓN")
            {
                TxtNumID.Text = "";
            }
        }

        private void TxtNumID_Leave(object sender, EventArgs e)
        {
            if (TxtNumID.Text == "")
            {
                TxtNumID.Text = "*N° IDENTIFICACIÓN";
            }
        }
        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "*CONTRASEÑA")
            {
                TxtContrasena.Text = "";
                TxtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "")
            {
                TxtContrasena.Text = "*CONTRASEÑA";
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void BtnIniciarSesClient_Click(object sender, EventArgs e)
        {
            if (TxtNumID.Text != "*N° IDENTIFICACIÓN")
            {
                if (TxtContrasena.Text != "*CONTRASEÑA")
                {
                    DatosClient enviar = new DatosClient();
                    enviar.NumIdUsu = TxtNumID.Text;
                    enviar.Contrasena = TxtContrasena.Text;
                    enviar.IdTipoPer = Convert.ToString(cmbTipoPer.SelectedValue);

                    Cache.IdTipoPer = Convert.ToString(cmbTipoPer.SelectedValue);

                    int res = UsuarioDAL_C.AccesoUsuarios(enviar);

                    if (res > 0)
                    {                        
                        if (enviar.IdTipoPer == "1")//Perfil Administrador
                        {
                            PerfilAdminSuc perfilAdminSuc = new PerfilAdminSuc();
                            perfilAdminSuc.Show();
                            this.Hide();
                        }
                        else if (enviar.IdTipoPer == "2")//Perfil Jefe de sucursal
                        {
                            PerfilJefSuc perfilJefSuc = new PerfilJefSuc();
                            perfilJefSuc.Show();
                            this.Hide();
                        }
                        else if (enviar.IdTipoPer == "3")//Perfil Gestor de sucursal
                        {
                            PerfilGesSuc perfilGesSuc = new PerfilGesSuc();
                            perfilGesSuc.Show();
                            this.Hide();
                        }
                        else if (enviar.IdTipoPer == "4")//Perfil Repartidor
                        {
                            PerfilRepSuc perfilRepartidor = new PerfilRepSuc();
                            perfilRepartidor.Show();
                            this.Hide();
                        }
                        else //Perfil Cliente
                        {
                            PerfilClientForm perfilCliente = new PerfilClientForm();
                            perfilCliente.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MensajeError("Usuario o Contraseña incorrectos.");
                    }
                }
                else
                    MensajeError("Ingrese una contraseña.");
            }
            else
                MensajeError("Ingrese N° Identificación");
        }

        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }

        public void ListarTipoPer()
        {
            UsuarioDAL_C TipoPer = new UsuarioDAL_C();
            cmbTipoPer.DataSource = TipoPer.ListarTipoPer();
            cmbTipoPer.DisplayMember = "DescTipoPer";
            cmbTipoPer.ValueMember = "IdTipoPer";
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta opción es solo para usuario tipo Clientes. \n ¿Desea seguir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RegClient registro = new RegClient();
                registro.Show();

                this.Hide();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}