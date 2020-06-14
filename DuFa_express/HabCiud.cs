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
    public partial class HabCiud : Form
    {
        public HabCiud()
        {
            InitializeComponent();
        }

        private void DtGrdVwHabCiu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HabCiud_Load(object sender, EventArgs e)
        {
            ListarCiudadesDesac();
        }
        public void ListarCiudadesDesac()
        {
            UsuarioDAL_C Suc = new UsuarioDAL_C();
            DtGrdVwHabCiu.DataSource = Suc.ListarCiudadesDesac();

        }

        private void BtnHabCiu_Click(object sender, EventArgs e)
        {
            if (DtGrdVwHabCiu.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de Reactivar esta Ciudad?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la desactivacion o Activacion

                    DatosClient enviar = new DatosClient();
                    enviar.Estado = true;
                    enviar.CiudadUsu = Convert.ToString(DtGrdVwHabCiu.CurrentRow.Cells["NOMCIUDAD"].Value);
                    int res = UsuarioDAL_C.EstadosCiudades(enviar);

                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Seleccione una ciudad a Reactivar");

            this.Close();
        }
    }
}
