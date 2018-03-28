#region NameSpace
    using HRMSWeb.BAL;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
#endregion NameSpace

namespace HRMSWeb
{
    public partial class Import : System.Web.UI.Page
    {

        #region Events

        #region Page_Load
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (null == Session["UserName"])
                Response.Redirect("~/Login.aspx");
        }
        #endregion Page_Load

        #region btnImport_Click
        /// <summary>
        /// btnImport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnImport_Click(object sender, EventArgs e)
        {

            switch(ddlType.SelectedItem.Value)
            {
                case "1":ImportEmployeeData();
                         break;
            }

        }
        #endregion btnImport_Click

        #endregion Events

        #region Methods

            #region ImportEmployeeData
            /// <summary>
            /// ImportEmployeeData
            /// </summary>
            private void ImportEmployeeData()
            {
                String path = Server.MapPath("~/FileImport/");
                Random rnd = new Random();
                String fileName = "Employee_Data" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "_" + rnd.Next() + ".csv";
                fileuploadExcel.PostedFile.SaveAs(path
                    + fileName);

                //FileStream stream = File.Open(path + fileName, FileMode.Open, FileAccess.Read);

                DataTable dtImport = CsvReader.ReadCSVFile(path + fileName, true);
                EmpBL ObjImport = new EmpBL();

                ObjImport.DtSource = dtImport;
                Boolean Result = ObjImport.ImportEmployeeData();


                if (Result)
                {
                    lblMessage.Text = "Successfully Imported!";
                    lblMessage.ForeColor = Color.Green;
                }
                else
                {
                    lblMessage.Text = "Faild!";
                    lblMessage.ForeColor = Color.Red;
                }
            }

            #endregion ImportEmployeeData

        #endregion Methods
    }
}