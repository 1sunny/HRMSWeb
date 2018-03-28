
#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HRMSWeb.BAL;
using System.Globalization;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
#endregion NameSpace


namespace HRMSWeb
{
    public partial class Attendance : System.Web.UI.Page
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
          
            if(null== Session["UserName"])
                Response.Redirect("~/Login.aspx");

            if (!IsPostBack)
              setDefaultDates();
        }
        #endregion Page_Load

        #region btnReport_Click
        /// <summary>
        /// btnReport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReport_Click(object sender, EventArgs e)
        {
            BindData();
        }
        #endregion btnReport_Click


        #region gdvAttendance_RowDataBound
        /// <summary>
        /// gdvAttendance_RowDataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gdvAttendance_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList DropDownList1 = (e.Row.FindControl("ddlL1Remarks") as DropDownList);
                EmpBL ObjEmp = new EmpBL();
                DataTable dt = ObjEmp.GetRemarks();

                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "Description";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("--Select--", "0"));

                if (Session["Privilege"].ToString() == "L1")
                {
                    TextBox TextBox1 = (e.Row.FindControl("txtL2Remarks") as TextBox);
                    TextBox1.Enabled = false;

                    CheckBox CheckBox1 = (e.Row.FindControl("chkLevel2") as CheckBox);
                    CheckBox1.Enabled = false;
                }

                if (Session["Privilege"].ToString() == "L2")
                {
                    DropDownList DropDownList2 = (e.Row.FindControl("ddlL1Remarks") as DropDownList);
                    DropDownList2.Enabled = false;
                    DropDownList2.Visible = false;

                    CheckBox CheckBox1 = (e.Row.FindControl("chkLevel1") as CheckBox);
                    CheckBox1.Enabled = false;
                }
            }
        }
        #endregion gdvAttendance_RowDataBound


        #region btnSave_Click
        /// <summary>
        /// btnSave_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new System.Data.DataColumn("Id", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new System.Data.DataColumn("EmpId", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("EmpName", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("CheckIn", typeof(String)));

            dt.Columns.Add(new System.Data.DataColumn("CheckOut", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("WorkedTime", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("ShiftId", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("SchIn", typeof(String)));

            dt.Columns.Add(new System.Data.DataColumn("SchOut", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("BreakOut", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("BreakIn", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("BreakTime", typeof(String)));

            dt.Columns.Add(new System.Data.DataColumn("UnderTime", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("UTAdj", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("OwedHours", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("OHAdj", typeof(int)));

            dt.Columns.Add(new System.Data.DataColumn("SystemRemarks", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("L1Remarks", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("L1Approve", typeof(bool)));
            dt.Columns.Add(new System.Data.DataColumn("L2Remarks", typeof(String)));

            dt.Columns.Add(new System.Data.DataColumn("L2Approve", typeof(bool)));
            dt.Columns.Add(new System.Data.DataColumn("StoreLocation", typeof(String)));
            bool flag = false;

            foreach (GridViewRow row in gdvAttendance.Rows)
            {

                Label Id = (Label)row.FindControl("Id");
                Label Date = (Label)row.FindControl("txtDate");
                Label EmpId = (Label)row.FindControl("lblEmpId");
                Label EmpName = (Label)row.FindControl("lblEmpName");
                Label CheckIn = (Label)row.FindControl("lblCheckIn");

                Label CheckOut = (Label)row.FindControl("lblCheckOut");
                Label WorkedTime = (Label)row.FindControl("lblWorkedTime");

                Label ShiftId = (Label)row.FindControl("lblShiftId");
                Label SchIn = (Label)row.FindControl("lblSchIn");
                Label SchOut = (Label)row.FindControl("lblSchOut");

                Label BreakOut = (Label)row.FindControl("lblBreakOut");
                Label BreakIn = (Label)row.FindControl("lblBreakIn");
                Label BreakTime = (Label)row.FindControl("lblBreakTime");
                Label UnderTime = (Label)row.FindControl("lblUnderTime");

                TextBox txtUnderTimeAdj = (TextBox)row.FindControl("txtUnderTimeAdj");
                Label OverTime = (Label)row.FindControl("lblOverTime");
                TextBox OwedHoursAdj = (TextBox)row.FindControl("txtOwedHoursAdj");
                Label SystemRemarks = (Label)row.FindControl("lblSystemRemarks");

                DropDownList ddlL1Remarks = (DropDownList)row.FindControl("ddlL1Remarks");
                CheckBox Level1 = (CheckBox)row.FindControl("chkLevel1");
                TextBox txtL2Remarks = (TextBox)row.FindControl("txtL2Remarks");
                CheckBox chkLevel2 = (CheckBox)row.FindControl("chkLevel2");

                

                dr = dt.NewRow();

                dr[0] = Id.Text;
                dr[1] = Date.Text;
                dr[2] = EmpId.Text;
                dr[3] = EmpName.Text;

                dr[4] = CheckIn.Text;
                dr[5] = CheckOut.Text;
                
                dr[6] = WorkedTime.Text;
                dr[7] = ShiftId.Text;
                dr[8] = SchIn.Text;

                dr[9] = SchOut.Text;
                dr[10] = BreakOut.Text;
                dr[11] = BreakIn.Text;
                dr[12] = BreakTime.Text;
            
                dr[13] = UnderTime.Text;
                dr[14] = txtUnderTimeAdj.Text;
                dr[15] = OverTime.Text;
                dr[16] = OwedHoursAdj.Text;

                dr[17] = SystemRemarks.Text;
                dr[18] = ddlL1Remarks.SelectedItem.Value;
                dr[19] = Level1.Checked;
                dr[20] = txtL2Remarks.Text;

                dr[21] = chkLevel2.Checked;
                dr[22] = Session["Location"].ToString();
                

                if (Level1.Checked)
                  dt.Rows.Add(dr);

                //if (ShiftId.SelectedItem.Value == "0")
                //{
                //    // row.Cells[i].BackColor = System.Drawing.Color.Red;
                //    ShiftId.BackColor = System.Drawing.Color.Red;
                //    flag = true;
                //}
              
            }

            if (!flag)
            {
                EmpBL ObjEmp = new EmpBL();
                ObjEmp.DtSource = dt;

                bool Result = false;

                if (Session["Privilege"].ToString() == "L1")
                {
                    Result = ObjEmp.SaveAttendance();
                }
                else
                {
                    dt.Columns.Remove("Date");
                    dt.Columns.Remove("EmpName");
                    dt.Columns.Remove("CheckIn");
                    dt.Columns.Remove("CheckOut");

                    dt.Columns.Remove("WorkedTime"); 
                    dt.Columns.Remove("ShiftId");
                    dt.Columns.Remove("SchIn");
                    dt.Columns.Remove("SchOut");

                    dt.Columns.Remove("BreakOut");
                    dt.Columns.Remove("BreakIn");
                    dt.Columns.Remove("BreakTime");
                    dt.Columns.Remove("UnderTime");

                    dt.Columns.Remove("UTAdj");
                    dt.Columns.Remove("OwedHours");
                    dt.Columns.Remove("OHAdj");
                    dt.Columns.Remove("SystemRemarks");

                    dt.Columns.Remove("L1Remarks");
                    dt.Columns.Remove("L1Approve");
                    dt.Columns.Remove("StoreLocation");

                    ObjEmp.DtSource = dt;


                    Result = ObjEmp.UpdateAttendanceLine();
                }

                if (Result)
                {
                    lblMessage.Text = "Successfully Saved";
                    lblMessage.ForeColor = System.Drawing.Color.Green;

                    string script = "alert(\"Successfully Saved!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    btnSave.Visible = false;
                    BindData();
                }
                else
                {
                    btnSave.Visible = true;
                    lblMessage.Text = "Failed !!!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "Please Put Proper Remarks";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        #endregion btnSave_Click

        #endregion Events

        #region Methods

        #region BindData
        /// <summary>
        /// BindData
        /// </summary>
        private void BindData()
        {
            if (txtFromDate.Text.Length > 0 && txtToDate.Text.Length > 0)
            {
                EmpBL objEmp = new EmpBL();
                objEmp.FromDate = DateTime.ParseExact(txtFromDate.Text.Trim().ToString(), "dd/MMM/yy", CultureInfo.InvariantCulture);
                objEmp.ToDate = DateTime.ParseExact(txtToDate.Text.Trim().ToString(), "dd/MMM/yy", CultureInfo.InvariantCulture);
                objEmp.WorkLocation = Session["Location"].ToString();
                DataTable dt = null;

                if (Session["Privilege"].ToString() == "L2")
                {
                    dt = objEmp.GetAttendanceLine();
                }
                else
                {
                    objEmp.EmpId = "All";
                    dt = objEmp.GetAttendance();
                }
                gdvAttendance.DataSource = dt;
                gdvAttendance.DataBind();
                btnSave.Visible = true;
            }
        }

        #endregion BindData

        #region setDefaultDates
        /// <summary>
        /// setDefaultDates
        /// </summary>
        private void setDefaultDates()
        {
            EmpBL empObj = new EmpBL();

            DataTable dt = empObj.GetServerDate();

            if (dt.Rows.Count > 0)
            {
                txtFromDate.Text = Convert.ToDateTime(dt.Rows[0]["FromDate"]).ToString("dd/MMM/yy");
                txtToDate.Text = Convert.ToDateTime(dt.Rows[0]["ToDate"]).ToString("dd/MMM/yy");
                txtFromDate.Enabled = false;
                txtToDate.Enabled = false;
            }


        }
        #endregion setDefaultDates



        #endregion Methods


    }
}