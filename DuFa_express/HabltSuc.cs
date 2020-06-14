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
    public partial class HabltSuc : Form
    {
        public HabltSuc()
        {
            InitializeComponent();
        }

        private void HabltSuc_Load(object sender, EventArgs e)
        {
            MostrarSucursales();
            
        }
        public void MostrarSucursales()
        {
            UsuarioDAL_C Suc = new UsuarioDAL_C();
            DtGrdVwHabSuc.DataSource = Suc.ListarSucursalesDesac();

        }

        private void BtnHabSuc_Click(object sender, EventArgs e)
        {
            if (DtGrdVwHabSuc.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de habilitar esta Sucursal?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la desactivacion

                    DatosClient enviar = new DatosClient();
                    enviar.Estado = true;
                    enviar.SucursalOperarios = Convert.ToString(DtGrdVwHabSuc.CurrentRow.Cells["NOMSUCURSAL"].Value);
                    int res = UsuarioDAL_C.EstadosSucursales(enviar);
                    
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Seleccione una Sucursal a Habilitar");

            this.Close();
        }

        private void BtnCanclHabSuc_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


    }
}
