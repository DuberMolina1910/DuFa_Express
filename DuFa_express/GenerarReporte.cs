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
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta de Envios Cancelados")
            {
                UsuarioDAL_C Reportes = new UsuarioDAL_C();
                DtGrdVwGenRepPerAdm.DataSource = Reportes.ReporteEnviosCancelados();
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
            else if (CmbBxTipRepGenRepPerAdm.Text == "Consulta de Envios Cancelados")
            {
                int CellHeader = 2, cellstart = 2;
                SLDocument sl = new SLDocument();
                sl.SetCellValue("B" + CellHeader, "N° GUIA");
                sl.SetCellValue("C" + CellHeader, "ID USUARIO");
                sl.SetCellValue("D" + CellHeader, "VALOR TOTAL");
                sl.SetCellValue("E" + CellHeader, "ESTADO");
                sl.SetCellValue("F" + CellHeader, "FECHA ENVIO");
                sl.SetCellValue("G" + CellHeader, "PERFIL");
                sl.SetCellValue("H" + CellHeader, "SUC. ORIGEN");
                sl.SetCellValue("I" + CellHeader, "SUC. DESTINO");
                sl.SetCellValue("J" + CellHeader, "ID DESTINATARIO");
                sl.SetCellValue("K" + CellHeader, "NOMBRE DESTINATARIO");
                sl.SetCellValue("L" + CellHeader, "TELEFONO DESTINATARIO");
                sl.SetCellValue("M" + CellHeader, "DIRECCION DESTINO");
                sl.SetCellValue("N" + CellHeader, "DETALLES DEL ENVIO");
                sl.SetCellValue("O" + CellHeader, "DETALLES DE CANCELACIÓN");

                SqlConnection Connect = DB_Connection.DBConnection();
                SqlCommand command = new SqlCommand(string.Format("SELECT LTRIM(RTRIM(REPLACE(TEN.IDENVIOGUIA, '', ''))) AS 'N° GUIA',LTRIM(RTRIM(REPLACE(TEN.NUMIDUSU, '', ''))) AS 'ID USUARIO',LTRIM(RTRIM(REPLACE(TEN.VALORENVIO, '', ''))) AS 'VALOR TOTAL',LTRIM(RTRIM(REPLACE(TES.DESCESTADO, '', ''))) AS ESTADO,LTRIM(RTRIM(REPLACE(TEN.FECHAENVIO, '', ''))) AS 'FECHA ENVIO',LTRIM(RTRIM(REPLACE(TTP.DESCTIPOPER, '', ''))) AS PERFIL,LTRIM(RTRIM(REPLACE(TSU.NOMSUCURSAL, '', ''))) AS 'SUC. ORIGEN',LTRIM(RTRIM(REPLACE(TSU2.NOMSUCURSAL, '', ''))) AS 'SUC. DESTINO',LTRIM(RTRIM(REPLACE(TEN.IDDESTINATARIO, '', ''))) AS 'ID DESTINATARIO',LTRIM(RTRIM(REPLACE(TEN.NOMDESTINATARIO, '', ''))) AS 'NOMBRE DESTINATARIO',LTRIM(RTRIM(REPLACE(TEN.TELDESTINATARIO, '', ''))) AS 'TELEFONO DESTINATARIO',LTRIM(RTRIM(REPLACE(TEN.DIRDESTINO, '', ''))) AS 'DIRECCION DESTINO',LTRIM(RTRIM(REPLACE(TEN.DETENVIO, '', ''))) AS 'DETALLES DEL ENVIO', LTRIM(RTRIM(REPLACE(TEN.DETCANCELACION, '', ''))) AS 'DETALLES DE CANCELACIÓN' FROM TABENVIOS TEN INNER JOIN TABESTADOS TES ON TES.IDESTADO = TEN.IDESTADO INNER JOIN TABTIPOPER TTP ON TEN.IDTIPOPER = TTP.IDTIPOPER INNER JOIN TABSUCURSALES TSU ON TEN.IDSUCORI = TSU.IDSUCURSAL INNER JOIN TABSUCURSALES TSU2 ON TEN.IDSUCDES = TSU2.IDSUCURSAL WHERE TEN.IDESTADO = '6' ORDER BY FECHAENVIO DESC"), Connect);
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    CellHeader++;
                    sl.SetCellValue("B" + CellHeader, Reader["N° GUIA"].ToString());
                    sl.SetCellValue("C" + CellHeader, Reader["ID USUARIO"].ToString());
                    sl.SetCellValue("D" + CellHeader, Reader["VALOR TOTAL"].ToString());
                    sl.SetCellValue("E" + CellHeader, Reader["ESTADO"].ToString());
                    sl.SetCellValue("F" + CellHeader, Reader["FECHA ENVIO"].ToString());
                    sl.SetCellValue("G" + CellHeader, Reader["PERFIL"].ToString());
                    sl.SetCellValue("H" + CellHeader, Reader["SUC. ORIGEN"].ToString());
                    sl.SetCellValue("I" + CellHeader, Reader["SUC. DESTINO"].ToString());
                    sl.SetCellValue("J" + CellHeader, Reader["ID DESTINATARIO"].ToString());
                    sl.SetCellValue("K" + CellHeader, Reader["NOMBRE DESTINATARIO"].ToString());
                    sl.SetCellValue("L" + CellHeader, Reader["TELEFONO DESTINATARIO"].ToString());
                    sl.SetCellValue("M" + CellHeader, Reader["DIRECCION DESTINO"].ToString());
                    sl.SetCellValue("N" + CellHeader, Reader["DETALLES DEL ENVIO"].ToString());
                    sl.SetCellValue("O" + CellHeader, Reader["DETALLES DE CANCELACIÓN"].ToString());

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

                sl.AutoFitColumn("B", "O");
                sl.SetCellStyle("B" + cellstart, "O" + CellHeader, CellStyle);

                sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "DF_REPORT_EnviosCancelados");
                sl.SaveAs("Report" + CmbBxTipRepGenRepPerAdm.Text + ".xlsx");
                MessageBox.Show("Reporte Generado a Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reader.Close();
                Connect.Close();
            }

        }
    }
}
