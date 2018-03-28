#region NameSpace
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using HRMSWeb.BAL;
    using System.Data;

#endregion NameSpace

namespace HRMSWeb
{
    public partial class UpdateEmployee : System.Web.UI.Page
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

            if (!IsPostBack)
               BindEmpId();
        }
        #endregion Page_Load


        #region cmbEmpId_SelectedIndexChanged
        /// <summary>
        /// cmbEmpId_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cmbEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpBL objEmp = new EmpBL();
            objEmp.EmpId = cmbEmpId.Text;
            DataTable dt = objEmp.GetEmpDetailsById();
            GetStore();
            lblMessage.Text = "";

            if (dt.Rows.Count>0)
            {
                txtName.Text = dt.Rows[0]["Name"].ToString();
                ChkStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Status"].ToString());
                ddlLocation.Text = dt.Rows[0]["Location"].ToString();
            }

        }
        #endregion cmbEmpId_SelectedIndexChanged


        #region btnUpdate_Click
        /// <summary>
        /// btnUpdate_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmpBL objEmp = new EmpBL();
            objEmp.StoreLocation = ddlLocation.Text;
            objEmp.EmpId = cmbEmpId.Text;
            objEmp.EmpStatus = ChkStatus.Checked;
            bool Result = objEmp.UpdateEmployeeInfo();

            if(Result)
            {
                lblMessage.Text = "Successfully Updated";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        #endregion btnUpdate_Click

        #endregion Events

        #region Methods

        #region GetStore
        /// <summary>
        /// GetStore
        /// </summary>
        private void GetStore()
        {
            EmpBL objEmp = new EmpBL();
            DataTable dt=objEmp.GetStore();

            ddlLocation.DataSource = dt;
            ddlLocation.DataMember = "LocationCode";
            ddlLocation.DataTextField = "LocationCode";
            ddlLocation.DataBind();
        }
        #endregion GetStore

        #region BindEmpId
        /// <summary>
        /// BindEmpId
        /// </summary>
        private void BindEmpId()
        {
            EmpBL objEmp = new EmpBL();
            DataTable dt = objEmp.GetAllEmployeeInfo();

            cmbEmpId.DataSource = dt;
            cmbEmpId.DataMember = "EmpId";
            cmbEmpId.DataTextField = "EmpId";
            cmbEmpId.DataBind();
        }

        #endregion BindEmpId

        #endregion Methods

       
    }
}