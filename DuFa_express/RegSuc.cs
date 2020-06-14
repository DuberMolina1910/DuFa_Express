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
    public partial class RegSuc : Form
    {
        public RegSuc()
        {
            InitializeComponent();
        }

        private void txtRegSuc_Enter(object sender, EventArgs e)
        {
            if (txtRegSuc.Text == "NOMBRE DE LA SUCURSAL")
            {
                txtRegSuc.Text = " ";
            }
        }

        private void txtRegCiudad_Leave(object sender, EventArgs e)
        {
            if (txtRegSuc.Text == " ")
            {
                txtRegSuc.Text = "NOMBRE DE LA SUCURSAL";
            }
        }

        private void RegSuc_Load(object sender, EventArgs e)
        {
            ListarCiudades();
            MostrarSucursales();
        }
        public void ListarCiudades()
        {
            UsuarioDAL_C Ciudad = new UsuarioDAL_C();
            CmbBxSelecCiudRegSuc.DataSource = Ciudad.ListarCiudades();
            CmbBxSelecCiudRegSuc.DisplayMember = "NomCiudad";
            CmbBxSelecCiudRegSuc.ValueMember = "IdCiudad";
        }
        public void MostrarSucursales()
        {
            UsuarioDAL_C Suc = new UsuarioDAL_C();
            DtGrdVwTabSuc.DataSource = Suc.ListarSucursales();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegSuc_Click(object sender, EventArgs e)
        {
            if (txtRegSuc.Text != "NOMBRE DE LA Sucursal")
            {
                if (UsuarioDAL_C.RegistrarSuc(Convert.ToInt32(CmbBxSelecCiudRegSuc.SelectedValue), txtRegSuc.Text) > 0)
                {
                    MensajeError("Ciudad registrada correctamente.");
                }
                else
                    MensajeError("La ciudad no pudo ser registrada.");
            }
            else
                MensajeError("Ingrese un nombre para la ciudad.");

            MostrarSucursales();

        }

        private void lblMsgError_Click(object sender, EventArgs e)
        {

        }

        private void MensajeError(string errorMsg)
        {
            lblMsgErrorSuc.Text = errorMsg;
            lblMsgErrorSuc.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DtGrdVwTabSuc.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de Desactivar esta Sucursal?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la desactivacion

                    DatosClient enviar = new DatosClient();
                    enviar.Estado = false;
                    enviar.SucursalOperarios = Convert.ToString(DtGrdVwTabSuc.CurrentRow.Cells["NOMSUCURSAL"].Value);
                    int res = UsuarioDAL_C.DesactivarSucursales(enviar);

                    MostrarSucursales();
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Seleccione una ciudad a eliminar");
        }

        private void BtnReactivarSuc_Click(object sender, EventArgs e)
        {
            HabltSuc habsuc = new HabltSuc();
            habsuc.ShowDialog();

        }

        private void BtnRfrsDtGrdVwRegSuc_Click(object sender, EventArgs e)
        {
            MostrarSucursales();
        }
    }
}
