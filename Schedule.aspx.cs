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
#endregion NameSpace

namespace HRMSWeb
{
    public partial class Schedule : System.Web.UI.Page
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


            setDefault();
        }
        #endregion Page_Load

        #region gdvSchedule_RowDataBound
        /// <summary>
        /// gdvSchedule_RowDataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gdvSchedule_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList DropDownList1 = (e.Row.FindControl("ddlShiftId1") as DropDownList);
                DropDownList DropDownList2 = (e.Row.FindControl("ddlShiftId2") as DropDownList);
                DropDownList DropDownList3 = (e.Row.FindControl("ddlShiftId3") as DropDownList);
                DropDownList DropDownList4 = (e.Row.FindControl("ddlShiftId4") as DropDownList);

                DropDownList DropDownList5 = (e.Row.FindControl("ddlShiftId5") as DropDownList);
                DropDownList DropDownList6 = (e.Row.FindControl("ddlShiftId6") as DropDownList);
                DropDownList DropDownList7 = (e.Row.FindControl("ddlShiftId7") as DropDownList);

                EmpBL ObjEmp = new EmpBL();
                DataTable dt = ObjEmp.GetShiftMaster();

                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "Description";
                DropDownList1.DataValueField = "ShiftHeaderId";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));

                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "Description";
                DropDownList2.DataValueField = "ShiftHeaderId";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));

                DropDownList3.DataSource = dt;
                DropDownList3.DataTextField = "Description";
                DropDownList3.DataValueField = "ShiftHeaderId";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));

                DropDownList4.DataSource = dt;
                DropDownList4.DataTextField = "Description";
                DropDownList4.DataValueField = "ShiftHeaderId";
                DropDownList4.DataBind();
                DropDownList4.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));


                DropDownList5.DataSource = dt;
                DropDownList5.DataTextField = "Description";
                DropDownList5.DataValueField = "ShiftHeaderId";
                DropDownList5.DataBind();
                DropDownList5.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));

                DropDownList6.DataSource = dt;
                DropDownList6.DataTextField = "Description";
                DropDownList6.DataValueField = "ShiftHeaderId";
                DropDownList6.DataBind();
                DropDownList6.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));

                DropDownList7.DataSource = dt;
                DropDownList7.DataTextField = "Description";
                DropDownList7.DataValueField = "ShiftHeaderId";
                DropDownList7.DataBind();
                DropDownList7.Items.Insert(0, new ListItem("--Select Shift Id--", "0"));
            }

        }
        #endregion gdvSchedule_RowDataBound

        #region btnSchdule_Click
        /// <summary>
        /// btnSchdule_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSchdule_Click(object sender, EventArgs e)
        {

            EmpBL ObjEmp = new EmpBL();
            
            ObjEmp.FromDate = DateTime.ParseExact(txtFromDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ObjEmp.ToDate = DateTime.ParseExact(txtToDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ObjEmp.WorkLocation = Session["Location"].ToString();
            DataTable dt = ObjEmp.GetEmpSchedule();
            if (dt.Rows.Count > 0)
            {
                lblMessage.Text = "Schedule is already uploaded!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                btnSave.Visible = false;
                gdvSchedule.Visible = false;
            }
            else if (DateTime.Now.DayOfWeek.ToString() != "Saturday" && DateTime.Now.DayOfWeek.ToString() != "Sunday")
            {
                lblMessage.Text = "You can not upload schedule today! (Sat Or Sun)";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                btnSave.Visible = false;
                gdvSchedule.Visible = false;
            }
            else
            {
                BindScheduleData();
                gdvSchedule.Visible = true;
                lblMessage.Text = "";
                btnSave.Visible = true;
            }
        }
        #endregion btnSchdule_Click
        
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
            dt.Columns.Add(new System.Data.DataColumn("EmpId", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("ShiftId", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("Date", typeof(String)));
            dt.Columns.Add(new System.Data.DataColumn("Location", typeof(String)));
            bool flag = false;

            foreach (GridViewRow row in gdvSchedule.Rows)
            {
                Label EmpId = (Label)row.FindControl("Label1");
                //Label Date = (Label)row.FindControl("Label4");

                DateTime Date = DateTime.ParseExact(txtFromDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);//Convert.ToDateTime(txtFromDate.Text);

                for (int i = 0; i < gdvSchedule.Columns.Count-2; i++)
                {
                    DropDownList ShiftId = (DropDownList)row.FindControl("ddlShiftId"+(i+1));
                    dr = dt.NewRow();
                    dr[0] = EmpId.Text;
                    dr[1] = ShiftId.SelectedItem.Value;
                    dr[2] = Date.AddDays(i);
                    dr[3] = Session["Location"].ToString();

                    if (ShiftId.SelectedItem.Value=="0")
                    {
                       // row.Cells[i].BackColor = System.Drawing.Color.Red;
                        ShiftId.BackColor=System.Drawing.Color.Red;
                        flag = true;
                    }
                    else
                    {
                        //row.Cells[i].BackColor = System.Drawing.Color.White;
                        ShiftId.BackColor = System.Drawing.Color.White;
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (!flag)
            {
                EmpBL ObjEmp = new EmpBL();
                ObjEmp.DtSource = dt;
                bool Result = ObjEmp.SaveSchedule();

                if (Result)
                {
                    lblMessage.Text = "Successfully Saved";
                    lblMessage.ForeColor = System.Drawing.Color.Green;

                    string script = "alert(\"Successfully Saved!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    btnSave.Visible = false;
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
                lblMessage.Text = "Please Put Proper Shift Id";
                lblMessage.ForeColor = System.Drawing.Color.Red;

            }


        }
        #endregion btnSave_Click

        #endregion Events

        #region Methods

        #region BindScheduleData
        /// <summary>
        /// BindScheduleData
        /// </summary>
        private void BindScheduleData()
        {
            EmpBL ObjEmp = new EmpBL();

           // ObjEmp.FromDate = Convert.ToDateTime(txtFromDate.Text);
            //ObjEmp.ToDate = Convert.ToDateTime(txtToDate.Text);
            //ObjEmp.WorkLocation = Session["Location"].ToString();
            ObjEmp.WorkLocation = Session["Location"].ToString();

            DataTable dt = ObjEmp.GetScheduleImportData();
            gdvSchedule.DataSource = dt;
            gdvSchedule.DataBind();

        }

        #endregion BindScheduleData

        #region setDefault
        /// <summary>
        /// setDefault
        /// </summary>
        private void setDefault()
        {
            DateTime now = DateTime.Now;
         

            var thisWeekStart = now.AddDays(-(int)now.DayOfWeek);
            var thisWeekEnd = thisWeekStart.AddDays(6);
            var NextWeekStart = thisWeekEnd.AddDays(1);
            var NextWeekEnd = thisWeekEnd.AddDays(7);

            var reportDate = DateTime.Now;

            if (DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {
                txtFromDate.Text = Convert.ToDateTime(NextWeekStart).ToString("dd/MM/yyyy");
                txtToDate.Text = Convert.ToDateTime(NextWeekEnd).ToString("dd/MM/yyyy");
            }
            else
            {
                txtFromDate.Text = Convert.ToDateTime(thisWeekStart).ToString("dd/MM/yyyy");
                txtToDate.Text = Convert.ToDateTime(thisWeekEnd).ToString("dd/MM/yyyy");
            }
         
        }
        #endregion setDefault
        
        #endregion Methods


    }
}