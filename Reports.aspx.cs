
#region NameSpace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Excel1 = Microsoft.Office.Interop.Excel;
using HRMSWeb.BAL;
using System.Globalization;
using System.Web;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
#endregion NameSpace

namespace HRMSWeb
{
    public partial class Reports : System.Web.UI.Page
    {

        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region btnReport_Click
        /// <summary>
        /// btnReport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            EmpBL objEmp = new EmpBL();
            Random rnd = new Random();
            objEmp.Date = DateTime.ParseExact(txtDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.WorkLocation = Session["Location"].ToString();
            objEmp.ReportType = rblType.SelectedItem.Value;

            if (rblType.SelectedItem.Value == "2")
            {
                dt = objEmp.GetAttendanceLineByDate();
                string filePath = Server.MapPath(".") + "\\Reports\\Attendance_Weekly" + "_" + rnd.Next() + ".csv";
                ViewState["FileNameAtt"] = filePath;
                StreamWriter sw = new StreamWriter(@filePath, false);
                ExportToCsv(dt, sw);
                sw.Close();
                btnDownload.Visible = true;
            }
            else if (rblType.SelectedItem.Value == "3")
            {
                dt = objEmp.GetAttendanceLineByDate();
                string filePath = Server.MapPath(".") + "\\Reports\\Attendance_Monthly" + "_" + rnd.Next() + ".csv";
                ViewState["FileNameAtt"] = filePath;
                StreamWriter sw = new StreamWriter(@filePath, false);
                ExportToCsv(dt, sw);
                sw.Close();
                btnDownload.Visible = true;
            }
            else
            {
                ExportAttendance();
            }

           
        }
        #endregion btnReport_Click

        #region btnDownload_Click
        /// <summary>
        /// btnDownload_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDownload_Click(object sender, EventArgs e)
        {
            string filename = ViewState["FileNameAtt"].ToString();
            FileDownload(filename);
        }
        #endregion btnDownload_Click
        #endregion Events

        #region ExportAttendance
        /// <summary>
        /// Export Attendance
        /// </summary>
        private void ExportAttendance()
        {
            try
            {
                Excel1.Application myExcelApp;

                Excel1.Workbooks myExcelWorkbooks;

                Excel1.Workbook myExcelWorkbook;


                object misValue = System.Reflection.Missing.Value;

                myExcelApp = new Excel1.Application();

                myExcelApp.Visible = false;

                myExcelWorkbooks = myExcelApp.Workbooks;

                string fileName = HttpContext.Current.Server.MapPath(".") + "\\Templates\\AttendanceExport.xlsx";

                myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
                Excel1.Worksheet xlSheet = (Excel1.Worksheet)myExcelWorkbook.Sheets[1];

                EmpBL objEmp = new EmpBL();
                objEmp.Date = DateTime.ParseExact(txtDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                objEmp.WorkLocation = Session["Location"].ToString();
                objEmp.ReportType = rblType.SelectedItem.Value;
                DataTable dtEmp = objEmp.GetAttendanceLineByDate();

                if (dtEmp.Rows.Count > 0)
                {
                    WriteToExcelAttendance(dtEmp, xlSheet);
                    // ExportToPdf(dtEmp);
                    string Password = "M@th0";

                    xlSheet.Protect(Password, misValue, misValue, misValue, misValue, misValue,
                    misValue, misValue, misValue, misValue, misValue, misValue, misValue,
                    misValue, misValue, misValue);

                    Random rnd = new Random();
                    string filePath = Server.MapPath(".") + "\\Reports\\Attendance_" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + rnd.Next() + ".xlsx";
                    ViewState["FileNameAtt"] = filePath;
                    myExcelWorkbook.SaveAs(@filePath);

                    myExcelWorkbook.Close();
                    myExcelWorkbooks.Close();
                    btnDownload.Visible = true;
                    lblMessage.Text = "Successfully Exported";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Text = "No Data Found";
                }
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.ToString();
            }
        }
        #endregion ExportAttendance

        #region WriteToExcelAttendance
        /// <summary>
        /// WriteToExcel Attendance
        /// </summary>
        /// <param name="dtStock"></param>
        /// <param name="myExcelWorksheet"></param>
        /// <param name="location"></param>
        private void WriteToExcelAttendance(DataTable dtEmp, Excel1.Worksheet myExcelWorksheet)
        {
            object misValue = System.Reflection.Missing.Value;

            myExcelWorksheet.get_Range("A2", misValue).Formula = "Attendance Report As Of " + txtDate.Text.Trim().ToString();

            myExcelWorksheet.Name = "Attendance";

            for (int i = 0; i < dtEmp.Rows.Count; i++)
            {
                myExcelWorksheet.get_Range("A" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["EmpId"]) ? dtEmp.Rows[i]["EmpId"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("A" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("B" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["EmpName"]) ? dtEmp.Rows[i]["EmpName"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("B" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));


                myExcelWorksheet.get_Range("C" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["SchIn"]) ? dtEmp.Rows[i]["SchIn"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("C" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("D" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["SchOut"]) ? dtEmp.Rows[i]["SchOut"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("D" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("E" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["CheckIn"]) ? dtEmp.Rows[i]["CheckIn"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("E" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("F" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["CheckOut"] && dtEmp.Rows[i]["CheckOut"].ToString().Length > 0) ? dtEmp.Rows[i]["CheckOut"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("F" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("G" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["UnderTime"] && dtEmp.Rows[i]["UnderTime"].ToString().Length > 0) ? dtEmp.Rows[i]["UnderTime"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("G" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("H" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["UTAdj"] && dtEmp.Rows[i]["UTAdj"].ToString().Length > 0) ? dtEmp.Rows[i]["UnderTime"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("H" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));



                myExcelWorksheet.get_Range("I" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["OwedHours"]) ? dtEmp.Rows[i]["OwedHours"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("I" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("J" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["OHAdj"]) ? dtEmp.Rows[i]["OHAdj"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("J" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("K" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["L1Remarks"]) ? dtEmp.Rows[i]["L1Remarks"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("K" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                myExcelWorksheet.get_Range("L" + (i + 4), misValue).Formula = (null != dtEmp.Rows[i]["L2Remarks"]) ? dtEmp.Rows[i]["L2Remarks"].ToString() : "";
                BorderAround(myExcelWorksheet.get_Range("L" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                BorderAround(myExcelWorksheet.get_Range("M" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                BorderAround(myExcelWorksheet.get_Range("N" + (i + 4), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

            }
        }

        #endregion WriteToExcelAttendance

        #region BorderAround
        /// <summary>
        /// Border Around
        /// </summary>
        /// <param name="range"></param>
        /// <param name="colour"></param>
        private void BorderAround(Excel1.Range range, int colour)
        {
            Excel1.Borders borders = range.Borders;
            borders[Excel1.XlBordersIndex.xlEdgeLeft].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeTop].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeBottom].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeRight].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[Excel1.XlBordersIndex.xlInsideVertical].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlDiagonalUp].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlDiagonalDown].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders = null;
        }

        #endregion BorderAround

        #region FileDownload
        /// <summary>
        /// File Download
        /// </summary>
        private void FileDownload(string filename)
        {

            FileInfo file = new FileInfo(filename);

            if (!file.Exists) return;
            if ((file.Extension == ".xlsx") || (file.Extension == ".XLSX") || (file.Extension == ".xls") || (file.Extension == ".XLS") || (file.Extension == ".csv"))
            {
                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", "attachment; filename=\"" + file.Name + "\"");
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.TransmitFile(file.FullName);
                Response.Flush();
                Response.End();
            }

        }
        #endregion FileDownload


        #region ExportToPdf
        /// <summary>
        /// ExportToPdf
        /// </summary>
        /// <param name="dt"></param>
        public void ExportToPdf(DataTable dt)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Server.MapPath(".") + "\\Reports\\Attendance_"+"Sample.pdf", FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[] { 4f, 4f, 4f, 4f,4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f ,4f};

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));
            

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {

                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    table.AddCell(new Phrase(r[0].ToString(), font5));
                    table.AddCell(new Phrase(r[1].ToString(), font5));
                    table.AddCell(new Phrase(r[2].ToString(), font5));
                    table.AddCell(new Phrase(r[3].ToString(), font5));

                    table.AddCell(new Phrase(r[4].ToString(), font5));
                    table.AddCell(new Phrase(r[5].ToString(), font5));
                    table.AddCell(new Phrase(r[6].ToString(), font5));
                    table.AddCell(new Phrase(r[7].ToString(), font5));

                    table.AddCell(new Phrase(r[8].ToString(), font5));
                    table.AddCell(new Phrase(r[9].ToString(), font5));
                    table.AddCell(new Phrase(r[10].ToString(), font5));
                    table.AddCell(new Phrase(r[11].ToString(), font5));

                    table.AddCell(new Phrase(r[12].ToString(), font5));
                    table.AddCell(new Phrase(r[13].ToString(), font5));
                    table.AddCell(new Phrase(r[14].ToString(), font5));
                    table.AddCell(new Phrase(r[15].ToString(), font5));

                    table.AddCell(new Phrase(r[16].ToString(), font5));
                    table.AddCell(new Phrase(r[17].ToString(), font5));
                    table.AddCell(new Phrase(r[18].ToString(), font5));
                    table.AddCell(new Phrase(r[19].ToString(), font5));

                    table.AddCell(new Phrase(r[20].ToString(), font5));
                    table.AddCell(new Phrase(r[21].ToString(), font5));
                    table.AddCell(new Phrase(r[22].ToString(), font5));
                    table.AddCell(new Phrase(r[23].ToString(), font5));
                    table.AddCell(new Phrase(r[24].ToString(), font5));
                }
            }

           
            document.Add(table);
            document.Close();
        }
        #endregion ExportToPdf

        #region Export To Csv
        /// <summary>
        /// Export To Csv
        /// </summary>
        /// <param name="dt"></param>
        private void ExportToCsv(DataTable dt, StreamWriter sw)
        {

            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                        sw.Write(dr[i].ToString());
                    if (i < iColCount - 1)
                        sw.Write(",");
                }
                sw.Write(sw.NewLine);
            }
            sw.Write(sw.NewLine);
        }

        #endregion Export To Csv
    }
}