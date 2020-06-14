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
    public partial class CalcValor : Form
    {
        public CalcValor()
        {
            InitializeComponent();
        }

        private void CalcValor_Load(object sender, EventArgs e)
        {
            ListarCiudadOrigen();
            ListarCiudadDestino();
        }

        public void ListarCiudadOrigen()
        {
            UsuarioDAL_C Ciudad = new UsuarioDAL_C();
            cmbCiudadOri.DataSource = Ciudad.ListarCiudades();
            cmbCiudadOri.DisplayMember = "NomCiudad";
            cmbCiudadOri.ValueMember = "IdCiudad";
        }

        public void ListarCiudadDestino()
        {
            UsuarioDAL_C Ciudad = new UsuarioDAL_C();
            cmbCiudadDes.DataSource = Ciudad.ListarCiudades();
            cmbCiudadDes.DisplayMember = "NomCiudad";
            cmbCiudadDes.ValueMember = "IdCiudad";
        }

        private void MensajeError(string errorMsg)
        {
            lblInfo.Text = errorMsg;
            //lblInfo.Visible = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int valorCiudad = 0;

            if (Convert.ToString(cmbCiudadOri.SelectedValue) == Convert.ToString(cmbCiudadDes.SelectedValue))
            {
                valorCiudad = 5000;

                MensajeError("Valor $ " + valorCiudad);
            }
            else
            {
                MensajeError("Valor $ " + valorCiudad);
            }
        }
    }
}
