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
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valorTotal = 0; // Variable valor Total del envio
            double vd = 0; // Variable para guardar el valor declarado del envio
            double vsp = 0; // Variable del valor sin peso cuando se declara un valor del envio
            double vc = 0; // Variable valor por ciudad
            double peso = 0; // Variable para guardar el peso
            double vp = 0; // Variable para guardar el valor cuando no se declara valor del envio, ósea el valor total solo se incrementa por peso


            if (Convert.ToString(cmbCiudadOri.SelectedValue) == Convert.ToString(cmbCiudadDes.SelectedValue) && txtPeso.Text != "")
            {
                vc = 5000;
                peso = Convert.ToInt32(txtPeso.Text);
                vd = Convert.ToInt32(txtValDeclarado.Text);

                if (vd != Convert.ToInt32("0"))
                {
                    if (vd <= 20000)
                    {
                        vsp = vc + (vc * 0.1);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 20001 && vd <= 50000)
                    {
                        vsp = vc + (vc * 0.25);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 50001 && vd <= 100000)
                    {
                        vsp = vc + (vc * 0.5);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 100001)
                    {
                        vsp = vc + 10000;

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString(valorTotal);
                    this.Close();
                }
                else if (Convert.ToString(vd) != "")
                {

                    vc = 5000;
                    peso = Convert.ToInt32(txtPeso.Text);
                    vp = vc;

                    if (peso <= 10)
                    {
                        valorTotal = vp + (vc * 0.05);
                    }
                    else if (peso >= 11 && peso <= 30)
                    {
                        valorTotal = vp + (vc * 0.1);
                    }
                    else if (peso >= 31 && peso <= 50)
                    {
                        valorTotal = vp + (vc * 0.2);
                    }
                    else if (peso >= 51)
                    {
                        valorTotal = vp + 3000;
                    }                    

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString(valorTotal);
                    this.Close();
                }
            }
            else if (Convert.ToString(cmbCiudadOri.SelectedValue) != Convert.ToString(cmbCiudadDes.SelectedValue) && txtPeso.Text != "")
            {
                vc = 10000;
                peso = Convert.ToInt32(txtPeso.Text);
                vd = Convert.ToInt32(txtValDeclarado.Text);

                if (vd != Convert.ToInt32("0"))
                {
                    if (vd <= 20000)
                    {
                        vsp = vc + (vc * 0.1);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 20001 && vd <= 50000)
                    {
                        vsp = vc + (vc * 0.25);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 50001 && vd <= 100000)
                    {
                        vsp = vc + (vc * 0.5);

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }
                    else if (vd >= 100001)
                    {
                        vsp = vc + 10000;

                        if (peso <= 10)
                        {
                            valorTotal = vsp + (vc * 0.05);
                        }
                        else if (peso >= 11 && peso <= 30)
                        {
                            valorTotal = vsp + (vc * 0.1);
                        }
                        else if (peso >= 31 && peso <= 50)
                        {
                            valorTotal = vsp + (vc * 0.2);
                        }
                        else if (peso >= 51)
                        {
                            valorTotal = vsp + 3000;
                        }
                    }

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString(valorTotal);
                    this.Close();
                }
                else if (Convert.ToString(vd) != "")
                {

                    vc = 10000;
                    peso = Convert.ToInt32(txtPeso.Text);
                    vp = vc;

                    if (peso <= 10)
                    {
                        valorTotal = vp + (vc * 0.05);
                    }
                    else if (peso >= 11 && peso <= 30)
                    {
                        valorTotal = vp + (vc * 0.1);
                    }
                    else if (peso >= 31 && peso <= 50)
                    {
                        valorTotal = vp + (vc * 0.2);
                    }
                    else if (peso >= 51)
                    {
                        valorTotal = vp + 3000;
                    }

                    CacheRegEnvio.ValTotalEnvio = Convert.ToString(valorTotal);
                    this.Close();
                }
            }
            else
            {
                MensajeError("Ingrese un peso valido");
            }
        }
    }
}
