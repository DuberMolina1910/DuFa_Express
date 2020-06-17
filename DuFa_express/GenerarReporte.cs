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
    public partial class GenerarReporte : Form
    {
        public GenerarReporte()
        {
            InitializeComponent();
        }

        private void GenerarReporte_Load(object sender, EventArgs e)
        {
            ReportConsultUsu();
        }

        public void ReportConsultUsu()
        {
            UsuarioDAL_C Reportes = new UsuarioDAL_C();
            DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultarUsuarios();
        }

        private void CmbBxTipRepGenRepPerAdm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Sucursal por Ciudades")
            {
                MessageBox.Show("Proceso", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Usuarios del Sistema")
            {
                ReportConsultUsu();
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta de Envios")
            {
                MessageBox.Show("Proceso", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCerrarGenRepPerAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
