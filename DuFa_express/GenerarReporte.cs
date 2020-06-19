using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void BtnExlGenRepPerAdm_Click(object sender, EventArgs e)
        {
            if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Usuarios del Sistema")
            {
                int CellHeader = 2, cellstart =2;
                SLDocument sl = new SLDocument();
                sl.SetCellValue("B" + CellHeader, "DESCTIPOPER");
                sl.SetCellValue("C" + CellHeader, "NUMIDUSU");
                sl.SetCellValue("D" + CellHeader, "NOMUSU");
                sl.SetCellValue("E" + CellHeader, "FECHNACUSU");
                sl.SetCellValue("F" + CellHeader, "TELUSU");
                sl.SetCellValue("G" + CellHeader, "CORREOUSU");
                sl.SetCellValue("H" + CellHeader, "DIRDOMUSU");
                sl.SetCellValue("I" + CellHeader, "NOMTIPOID");

                SqlConnection Connect = DB_Connection.DBConnection();
                SqlCommand command = new SqlCommand(string.Format("SELECT DESCTIPOPER,NUMIDUSU,NOMUSU,FECHNACUSU,TELUSU,CORREOUSU,DIRDOMUSU,NOMTIPOID FROM TABUSUARIOS,TABTIPOPER, TABTIPOID WHERE TABUSUARIOS.IDTIPOPER = TABTIPOPER.IDTIPOPER AND TABUSUARIOS.IDTIPOID = TABTIPOID.IDTIPOID ORDER BY DESCTIPOPER"), Connect);
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    CellHeader++;
                    sl.SetCellValue("B" + CellHeader, Reader["DESCTIPOPER"].ToString());
                    sl.SetCellValue("C" + CellHeader, Reader["NUMIDUSU"].ToString());
                    sl.SetCellValue("D" + CellHeader, Reader["NOMUSU"].ToString());
                    sl.SetCellValue("E" + CellHeader, Reader["FECHNACUSU"].ToString());
                    sl.SetCellValue("F" + CellHeader, Reader["TELUSU"].ToString());
                    sl.SetCellValue("G" + CellHeader, Reader["CORREOUSU"].ToString());
                    sl.SetCellValue("H" + CellHeader, Reader["DIRDOMUSU"].ToString());
                    sl.SetCellValue("I" + CellHeader, Reader["NOMTIPOID"].ToString());
                }

                SLStyle CellStyle = sl.CreateStyle();
                CellStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.TopBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.BottomBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.RightBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.LeftBorder.Color = System.Drawing.Color.Black;

                sl.AutoFitColumn("B", "I");
                sl.SetCellStyle("B" + cellstart, "I" + CellHeader, CellStyle);

                sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "DF_REPORT_SystemUsers");
                sl.SaveAs("Report" + CmbBxTipRepGenRepPerAdm.Text + ".xlsx");
                MessageBox.Show("Reporte Generado a Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reader.Close();
                Connect.Close();
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta Asignacion de Usuarios - Sucursales")
            {
                int CellHeader = 2, cellstart = 2;
                SLDocument sl = new SLDocument();
                sl.SetCellValue("B" + CellHeader, "NOMCIUDAD");
                sl.SetCellValue("C" + CellHeader, "NOMSUCURSAL");
                sl.SetCellValue("D" + CellHeader, "NOMUSU");
                sl.SetCellValue("E" + CellHeader, "NUMIDUSU");
                sl.SetCellValue("F" + CellHeader, "DESCTIPOPER");
                

                SqlConnection Connect = DB_Connection.DBConnection();
                SqlCommand command = new SqlCommand(string.Format("SELECT TABCIUDADES.NOMCIUDAD,TABSUCURSALES.NOMSUCURSAL,TABUSUARIOS.NOMUSU,TABUSUARIOS.NUMIDUSU,TABTIPOPER.DESCTIPOPER FROM TABCIUDADES, TABSUCURSALES, TABUSUARIOS, TABTIPOPER WHERE TABCIUDADES.IDCIUDAD = TABSUCURSALES.IDCIUDAD AND TABTIPOPER.IDTIPOPER = TABUSUARIOS.IDTIPOPER AND TABSUCURSALES.IDSUCURSAL = TABUSUARIOS.SUCOPERARIOS ORDER BY NOMCIUDAD"), Connect);
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    CellHeader++;
                    sl.SetCellValue("B" + CellHeader, Reader["NOMCIUDAD"].ToString());
                    sl.SetCellValue("C" + CellHeader, Reader["NOMSUCURSAL"].ToString());
                    sl.SetCellValue("D" + CellHeader, Reader["NOMUSU"].ToString());
                    sl.SetCellValue("E" + CellHeader, Reader["NUMIDUSU"].ToString());
                    sl.SetCellValue("F" + CellHeader, Reader["DESCTIPOPER"].ToString());
                    
                }

                SLStyle CellStyle = sl.CreateStyle();
                CellStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.TopBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.BottomBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.RightBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.LeftBorder.Color = System.Drawing.Color.Black;

                sl.AutoFitColumn("B", "F");
                sl.SetCellStyle("B" + cellstart, "F" + CellHeader, CellStyle);

                sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "DF_REPORT_SystemUsersperSuc");
                sl.SaveAs("Report" + CmbBxTipRepGenRepPerAdm.Text + ".xlsx");
                MessageBox.Show("Reporte Generado a Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reader.Close();
                Connect.Close();
            }
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta de Envios por sucursales")
            {
                int CellHeader = 2, cellstart = 2;
                SLDocument sl = new SLDocument();
                sl.SetCellValue("B" + CellHeader, "NOMCIUDAD");
                sl.SetCellValue("C" + CellHeader, "NOMSUCURSAL");
                sl.SetCellValue("D" + CellHeader, "IDENVIOGUIA");
                sl.SetCellValue("E" + CellHeader, "FECHAENVIO");
                sl.SetCellValue("F" + CellHeader, "VALORENVIO");
                sl.SetCellValue("G" + CellHeader, "DESCESTADO");
               
                SqlConnection Connect = DB_Connection.DBConnection();
                SqlCommand command = new SqlCommand(string.Format("SELECT TABCIUDADES.NOMCIUDAD,TABSUCURSALES.NOMSUCURSAL,TABENVIOS.IDENVIOGUIA,TABENVIOS.FECHAENVIO,TABENVIOS.VALORENVIO,TABESTADOS.DESCESTADO FROM TABENVIOS, TABSUCURSALES, TABCIUDADES,TABESTADOS WHERE TABCIUDADES.IDCIUDAD = TABSUCURSALES.IDSUCURSAL AND TABENVIOS.IDSUCORI = TABSUCURSALES.IDSUCURSAL AND TABESTADOS.IDESTADO = TABENVIOS.IDESTADO ORDER BY NOMCIUDAD"), Connect);
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    CellHeader++;
                    sl.SetCellValue("B" + CellHeader, Reader["NOMCIUDAD"].ToString());
                    sl.SetCellValue("C" + CellHeader, Reader["NOMSUCURSAL"].ToString());
                    sl.SetCellValue("D" + CellHeader, Reader["IDENVIOGUIA"].ToString());
                    sl.SetCellValue("E" + CellHeader, Reader["FECHAENVIO"].ToString());
                    sl.SetCellValue("F" + CellHeader, Reader["VALORENVIO"].ToString());
                    sl.SetCellValue("G" + CellHeader, Reader["DESCESTADO"].ToString());

                }

                SLStyle CellStyle = sl.CreateStyle();
                CellStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.TopBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.BottomBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.RightBorder.Color = System.Drawing.Color.Black;
                CellStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                CellStyle.Border.LeftBorder.Color = System.Drawing.Color.Black;

                sl.AutoFitColumn("B", "G");
                sl.SetCellStyle("B" + cellstart, "G" + CellHeader, CellStyle);

                sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "DF_REPORT_EnviosperSuc");
                sl.SaveAs("Report" + CmbBxTipRepGenRepPerAdm.Text + ".xlsx");
                MessageBox.Show("Reporte Generado a Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reader.Close();
                Connect.Close();
            }

            
        }
    }
}
