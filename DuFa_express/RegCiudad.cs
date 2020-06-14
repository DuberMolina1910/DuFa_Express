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
    public partial class RegCiudad : Form
    {
        public RegCiudad()
        {
            InitializeComponent();
        }

        private void txtRegCiudad_Enter(object sender, EventArgs e)
        {
            if (txtRegCiudad.Text == "NOMBRE DE LA CIUDAD")
            {
                txtRegCiudad.Text = "";
            }
        }

        private void txtRegCiudad_Leave(object sender, EventArgs e)
        {
            if (txtRegCiudad.Text == "")
            {
                txtRegCiudad.Text = "NOMBRE DE LA CIUDAD";
            }
        }

        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }

        private void txtRegCiudad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRegCiudad_Click(object sender, EventArgs e)
        {
            if (txtRegCiudad.Text != "NOMBRE DE LA CIUDAD")
            {
                if (UsuarioDAL_C.RegistrarCiudad(txtRegCiudad.Text) > 0)
                {
                    MensajeError("Ciudad registrada correctamente.");
                }
                else 
                    MensajeError("La ciudad no pudo ser registrada.");
            }
            else
                MensajeError("Ingrese un nombre para la ciudad.");

            MostrarCiudades();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegCiudad_Load(object sender, EventArgs e)
        {

            MostrarCiudades();

        }
        public void MostrarCiudades()
        {
            UsuarioDAL_C Ciudad = new UsuarioDAL_C();
            DtGrdVTabCiudades.DataSource = Ciudad.MostrarCiudades();
            
        }

        private void btnCancelarCiudad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElimCiudad_Click(object sender, EventArgs e)
        {
            
            if (DtGrdVTabCiudades.SelectedRows.Count > 0)
            {                               
                if (MessageBox.Show("¿Esta seguro de Desactivar esta Ciudad?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la desactivacion
                    
                    DatosClient enviar = new DatosClient();
                    enviar.Estado = true;
                    enviar.CiudadUsu = Convert.ToString(DtGrdVTabCiudades.CurrentRow.Cells["NOMCIUDAD"].Value);
                    int res = UsuarioDAL_C.DesactivarCiudades(enviar);
                    
                    MostrarCiudades();
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Seleccione una ciudad a eliminar");
        }

        private void BtnReacCiud_Click(object sender, EventArgs e)
        {
            HabCiud habciud = new HabCiud();
            habciud.ShowDialog();
        }

        private void BtnRfrsCiud_Click(object sender, EventArgs e)
        {
            MostrarCiudades();
        }
    }
}
