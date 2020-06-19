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
    public partial class GesEnvios : Form
    {
        public GesEnvios()
        {
            InitializeComponent();
        }

        private void GesEnvios_Load(object sender, EventArgs e)
        {
            ListarEstados();
            GetTabEnviosDGV();
            cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
            OpcPerfil();
        }

        private void txtNumGuia_Enter(object sender, EventArgs e)
        {
            if (txtNumGuia.Text == "*N° GUIA")
            {
                txtNumGuia.Text = "";
            }            
        }

        private void txtNumGuia_Leave(object sender, EventArgs e)
        {
            if (txtNumGuia.Text == "")
            {
                txtNumGuia.Text = "*N° GUIA";
            }
        }

        private void OpcPerfil()
        {
            if (Cache.IdTipoPer == "1")
            {
                btnSolAnulacion.Visible = false;
            }
            else if (Cache.IdTipoPer == "5")
            {
                btnAnularEnvio.Visible = false;
            }
        }

        private void GetTabEnviosDGV()
        {
            UsuarioDAL_C enviar = new UsuarioDAL_C();
            dgvGesEnvios.DataSource = enviar.getTabEnviosDGV();
        }

        private void ListarEstados()
        {
            UsuarioDAL_C enviar = new UsuarioDAL_C();
            cmbEstadoEnvio.DataSource = enviar.ListarEstados();
            cmbEstadoEnvio.DisplayMember = "DescEstado";
            cmbEstadoEnvio.ValueMember = "IdEstado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumGuia.Text != "*N° GUIA")
            {
                UsuarioDAL_C enviar = new UsuarioDAL_C();
                DatosClient datos = new DatosClient();
                datos.NumIdUsu = txtNumGuia.Text;
                dgvGesEnvios.DataSource = enviar.getTabEnviosGuiaDGV(datos);                

                if (dgvGesEnvios.Rows.Count < 1)
                {
                    lblMsgError.Visible = true;
                    MensajeError("No se encontraron registros con ese numero de guia.");
                }
                else
                    lblMsgError.Visible = false;

            }
            else if (cmbEstadoEnvio.Text != "*ESTADO ENVÍO")
            {
                UsuarioDAL_C enviar = new UsuarioDAL_C();
                DatosClient datos = new DatosClient();
                datos.IdEstadoEnvio = Convert.ToString(cmbEstadoEnvio.SelectedValue);
                dgvGesEnvios.DataSource = enviar.getTabEnviosEstadoDGV(datos);

                if (dgvGesEnvios.Rows.Count < 1)
                {
                    lblMsgError.Visible = true;
                    MensajeError("No se encontraron registros con ese estado.");
                }
                else
                    lblMsgError.Visible = false;
            }
            else
            {
                GetTabEnviosDGV();
                lblMsgError.Visible = false;
            }
            cmbEstadoEnvio.Text = "*ESTADO ENVÍO";
        }

        private void btnAnularEnvio_Click(object sender, EventArgs e)
        {
            if (dgvGesEnvios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llevar a cabo la anulación del envío
                    DatosClient enviar = new DatosClient();
                    enviar.IdEstadoEnvio = "6";
                    enviar.IdEnvioGuia = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["N° GUIA"].Value);
                    int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                    MensajeError("El envío ha sido anulado exitosamente.");
                }
            }
            else
                MensajeError("Seleccione el envío a anular.");
        }
        private void MensajeError(string errorMsg)
        {
            lblMsgError.Text = errorMsg;
            lblMsgError.Visible = true;
        }

        private void btnSolAnulacion_Click(object sender, EventArgs e)
        {
            lblMsgError.Visible = false;
            if (dgvGesEnvios.SelectedRows.Count > 0)
            {
                DatosClient enviar = new DatosClient();
                enviar.IdEstadoEnvio = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["ESTADO"].Value);
                enviar.ValTotalEnvio = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["VALOR TOTAL"].Value);

                int valAnul = 0;
                int valEnvio = Convert.ToInt32(enviar.ValTotalEnvio);

                if (enviar.IdEstadoEnvio == "Recepcionado en sucursal" || enviar.IdEstadoEnvio == "Nuevo")
                {                    
                    if (MessageBox.Show("El valor por la anulación del envío es de: COP $ " + valAnul + " \n¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Llevar a cabo la anulación del envío

                        enviar.IdEstadoEnvio = "8";
                        enviar.IdEnvioGuia = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["N° GUIA"].Value);
                        int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                        MensajeError("La soliciud se ha realizado exitosamente.");
                        GetTabEnviosDGV();
                    }
                }
                else if (enviar.IdEstadoEnvio == "Tránsito a destino")
                {
                    valAnul = valEnvio/4;

                    if (MessageBox.Show("El valor por la anulación del envío es de: COP $ " + valAnul + " \n¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Llevar a cabo la anulación del envío

                        enviar.IdEstadoEnvio = "8";
                        enviar.IdEnvioGuia = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["N° GUIA"].Value);
                        int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                        MensajeError("La soliciud se ha realizado exitosamente.");
                        GetTabEnviosDGV();
                    }
                }
                else if (enviar.IdEstadoEnvio == "DPO")
                {
                    valAnul = valEnvio / 2;

                    if (MessageBox.Show("El valor por la anulación del envío es de: COP $ " + valAnul + " \n¿Esta seguro de anular el envio?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Llevar a cabo la anulación del envío

                        enviar.IdEstadoEnvio = "8";
                        enviar.IdEnvioGuia = Convert.ToString(dgvGesEnvios.CurrentRow.Cells["N° GUIA"].Value);
                        int res = UsuarioDAL_C.AnulacionEnvio(enviar);
                        MensajeError("La soliciud se ha realizado exitosamente.");
                        GetTabEnviosDGV();
                    }
                }
                else
                {
                    if (enviar.IdEstadoEnvio == "Entregado" || enviar.IdEstadoEnvio == "Finalizado y Confirmado")
                    {
                        MensajeError("El estado del pedido no permite cancelarlo porque este ya se finalizo.");
                    }
                    else if (enviar.IdEstadoEnvio == "Cancelado")
                    {
                        MensajeError("Este envío ya fue cancelado.");
                    }
                    else if (enviar.IdEstadoEnvio == "Solicitud de Cancelación")
                    {
                        MensajeError("Este envío ya se encuentra en proceso de validación para su cancelación.");
                    }
                }
            }
            else
            {
                MensajeError("Seleccione el envío al cual desea solicitar la anulación.");
            }
        }
    }
}
