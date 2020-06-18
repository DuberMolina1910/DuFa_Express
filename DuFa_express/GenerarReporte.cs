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
            //ReportConsultUsu();
            //ReportConsultUsuxSuc();
            //ReportConsultEnvxSuc();
            //ReportGen();
        }

        public void ReportConsultUsu()
        {
            UsuarioDAL_C Reportes = new UsuarioDAL_C();
            DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultarUsuarios();
        }
        public void ReportConsultUsuxSuc()
        {
            UsuarioDAL_C Reportes = new UsuarioDAL_C();
            DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultaUsuarioxSuc();
        }
        public void ReportConsultEnvxSuc()
        {
            UsuarioDAL_C Reportes = new UsuarioDAL_C();
            DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultaEnvxSuc();
        }
        //public void ReportGen()
        //{
        //    UsuarioDAL_C Reportes = new UsuarioDAL_C();
        //    DtGrdVwGenRepPerAdm.DataSource = Reportes.ReportedatosGen();
        //}



        private void CmbBxTipRepGenRepPerAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Asignacion de Usuarios - Sucursales")
            {
                UsuarioDAL_C Reportes = new UsuarioDAL_C();
                DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultaUsuarioxSuc();
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Usuarios del Sistema")
            {
                UsuarioDAL_C Reportes = new UsuarioDAL_C();
                DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultarUsuarios();
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta de Envios por sucursales")
            {
                UsuarioDAL_C Reportes = new UsuarioDAL_C();
                DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteCosultaEnvxSuc();
            }
        }

        private void BtnCerrarGenRepPerAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
