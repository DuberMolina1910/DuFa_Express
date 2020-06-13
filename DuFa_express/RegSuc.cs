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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
