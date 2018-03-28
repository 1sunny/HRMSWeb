#region NameSpace
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMSWeb.BAL;
#endregion NameSpace
namespace HRMSWeb
{
    public partial class Offer : System.Web.UI.Page
    {

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


        #region btnValidate_Click
        /// <summary>
        /// btnValidate_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnValidate_Click(object sender, EventArgs e)
        {
            EmpBL ObjEmp = new EmpBL();
            ObjEmp.MobileNo = Convert.ToDecimal(txtMobileNo.Text.Trim());
            DataTable dt=ObjEmp.GetOfferCode();

            if(dt.Rows.Count>0)
            {
                txtOfferCode.Text = dt.Rows[0]["Code"].ToString();

                lblMessage.Text = "Valid Offer Code Available";
                lblMessage.ForeColor = Color.Green;
                btnUseCode.Visible = true;
            }
            else
            {
                lblMessage.Text = "No Valid Offer Code Available";
                txtOfferCode.Text = "";
                btnUseCode.Visible = false;
                lblMessage.ForeColor = Color.Red;
            }

        }
        #endregion btnValidate_Click

        #region btnUseCode_Click
        /// <summary>
        /// btnUseCode_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUseCode_Click(object sender, EventArgs e)
        {
            EmpBL ObjEmp = new EmpBL();
            ObjEmp.MobileNo = Convert.ToDecimal(txtMobileNo.Text.Trim());
            ObjEmp.OfferCode = txtOfferCode.Text.Trim();
            ObjEmp.StoreLocation = Session["Location"].ToString();
            bool Result = ObjEmp.UpdateOffer();

            if (Result)
            {
                lblMessage.Text = "Successfully Updated!";
                lblMessage.ForeColor = Color.Green;
                btnUseCode.Visible = false;
            }
            else
            {
                lblMessage.Text = "Faild";
                txtOfferCode.Text = "";
                btnUseCode.Visible = false;
                lblMessage.ForeColor = Color.Red;
            }

        }
        #endregion btnUseCode_Click
    }
}