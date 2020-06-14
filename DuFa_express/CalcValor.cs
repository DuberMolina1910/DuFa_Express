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

        private void txtValDeclarado_Enter(object sender, EventArgs e)
        {
            if (txtValDeclarado.Text == "0")
            {
                txtValDeclarado.Text = "";
            }
        }

        private void txtValDeclarado_Leave(object sender, EventArgs e)
        {
            if (txtValDeclarado.Text == "")
            {
                txtValDeclarado.Text = "0";
            }
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
            double valorTotal = 0;
            double valorCiudad = 0;
            double seguro = 0;
            double peso = 0;
            

            if (Convert.ToString(cmbCiudadOri.SelectedValue) == Convert.ToString(cmbCiudadDes.SelectedValue) && txtPeso.Text != "")
            {
                valorCiudad = 5000;
                peso = Convert.ToDouble(txtPeso.Text);
                valorTotal = valorCiudad;

                if (txtValDeclarado.Text != "0")
                {
                    seguro = 10000;
                    valorTotal = valorCiudad + seguro;

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString("$ " + valorTotal);
                }
                else
                {
                    CacheRegEnvio.ValTotalEnvio = Convert.ToString("$ " + valorTotal);
                }
                this.Close();
            }

            else if (txtPeso.Text != "")
            {
                valorCiudad = 10000;
                peso = Convert.ToDouble(txtPeso.Text);
                valorTotal = valorCiudad;

                if (txtValDeclarado.Text != "0")
                {
                    seguro = 10000;
                    valorTotal = valorCiudad + seguro;

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString("$ " + valorTotal);
                }
                else
                {
                    CacheRegEnvio.ValTotalEnvio = Convert.ToString("$ " + valorTotal);
                }
                this.Close();
            }
            else
            {
                MensajeError("Ingrese un peso valido");
            }
        }        
    }
}
