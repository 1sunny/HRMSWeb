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
    public partial class Login : System.Web.UI.Page
    {

        #region  Page_Load
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        #endregion Page_Load


        #region btnLogin_Click
        /// <summary>
        /// btnLogin_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                EmpBL objEmp = new EmpBL();
                objEmp.EmpId = txtUsername.Text.Trim();
                objEmp.Password = txtPassword.Text.Trim();
                DataTable dt = objEmp.GetLogin();

                lblMessage.Text = objEmp.ExceptionMessage;
                lblMessage.ForeColor = System.Drawing.Color.Red;

                if (dt.Rows.Count > 0)
                {
                    Session["UserName"] = dt.Rows[0]["EmpId"].ToString();
                    Session["Privilege"] = dt.Rows[0]["Privilege"].ToString();
                    Session["Location"] = dt.Rows[0]["Location"].ToString();

                    if (dt.Rows[0]["Privilege"].ToString() == "L3")
                    {
                        Response.Redirect("~/Offer.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/Attendance.aspx");
                    }

                }
                else
                {
                    //Session["UserName"] = "tt";
                    //Response.Redirect("~/Attendance.aspx");
                    //lblMessage.Text = objEmp.ExceptionMessage;
                    //lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.ToString();
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion btnLogin_Click
    }
}