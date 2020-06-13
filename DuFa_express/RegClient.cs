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
    public partial class RegClient : Form
    {
        public RegClient()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtBxContrasenaClient.Text == TxtBxConfirContraClient.Text)
            {
                DatosClient enviar = new DatosClient();
                enviar.NomUsu = TxtBxNombreClient.Text;
                enviar.NumIdUsu = TxtBxIdClient.Text;
                enviar.FechNacUsu = MskTxtbxFechaNacClient.Text;
                enviar.TelUsu = TxtBxTelefonoClient.Text;
                enviar.CorreoUsu = TxtBxEmailClient.Text;
                enviar.DirDomUsu = TxtBxDirDomClient.Text;
                enviar.Contrasena = TxtBxContrasenaClient.Text;
                enviar.IdTipoId = Convert.ToString(CmbBoxIdTipoId.SelectedValue);

                int resultado = UsuarioDAL_C.RegistrarData(enviar, "5");

                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se guardaron los datos correctamente", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
                Index index = new Index();
                index.Show();
            }
        }
        
        public void ListarTipoId()
        {
            UsuarioDAL_C TipoId = new UsuarioDAL_C();
            CmbBoxIdTipoId.DataSource = TipoId.ListarIdTipoId();
            CmbBoxIdTipoId.DisplayMember = "NomTipoId";
            CmbBoxIdTipoId.ValueMember = "IdTipoId";
        }

        private void RegClient_Load(object sender, EventArgs e)
        {
            ListarTipoId();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }
    }
}
