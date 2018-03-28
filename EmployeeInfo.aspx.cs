#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMSWeb.BAL;
using System.Globalization;
using System.Data;

#endregion NameSpace

namespace HRMSWeb
{
    public partial class EmployeeInfo : System.Web.UI.Page
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
            BindEmpId();
        }
        #endregion Page_Load

        #region btnAddEmp_Click
        /// <summary>
        /// btnAddEmp_Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddEmp_Click(object sender, EventArgs e)
        {
            InsertEmpInfo();
        }
        #endregion btnAddEmp_Click

        #region ddlEmpId_SelectedIndexChanged
        /// <summary>
        /// ddlEmpId_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindEmpDetails();
        }
        #endregion ddlEmpId_SelectedIndexChanged

        #region btnUpdateEmp_Click
        /// <summary>
        /// btnUpdateEmp_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            UpdateEmpInfo();
        }
        #endregion btnUpdateEmp_Click
        
        #endregion Events

        #region Methods

        #region InsertEmpInfo
        /// <summary>
        /// InsertEmpInfo
        /// </summary>
        private void InsertEmpInfo()
        {
            EmpBL objEmp = new EmpBL();

            objEmp.EmpId = ddlEmpId.SelectedItem.Value;
            objEmp.FirstName = txtFirstName.Text.Trim();
            objEmp.MiddleName = txtMiddleName.Text.Trim();
            objEmp.LastName = txtLastName.Text.Trim();

            objEmp.DOB = DateTime.ParseExact(txtDOB.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.Gender =ddlGender.SelectedItem.Value;
            objEmp.PresentAddress = txtPresentAddress.Text.Trim();
            objEmp.PermanentAddress = txtPermanentAddress.Text.Trim();

            objEmp.JoiningDate = DateTime.ParseExact(txtJoiningDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            objEmp.MaritalStatus = ddlMaritalStatus.SelectedItem.Value;
            objEmp.Nationality = txtNationality.Text.Trim();
            objEmp.EmpStatus = true;

            objEmp.Phone1 = txtPhoneNo.Text.Trim();
            objEmp.PhoneHomeCountry = txtPhoneHome.Text.Trim();
            objEmp.Email = txtEmail.Text.Trim();
            objEmp.WorkLocation = ddlWorkLocation.SelectedItem.Value;

            objEmp.Designation = ddlDesignation.SelectedItem.Text;
            objEmp.PassportNo = txtPassportNo.Text.Trim();
            objEmp.PassportValidFrom = DateTime.ParseExact(txtPassportValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            objEmp.PassportValidTill = DateTime.ParseExact(txtPassportValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            objEmp.VisaNo = txtVisaNo.Text;
            objEmp.VisaType = txtVisaType.Text;
            objEmp.VisaValidFrom = DateTime.ParseExact(txtVisaValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            objEmp.VisaValidTill = DateTime.ParseExact(txtVisaValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            
            objEmp.IDNo = txtIDNo.Text.Trim();
            objEmp.IDValidFrom = DateTime.ParseExact(txtIDValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            objEmp.IDValidTill = DateTime.ParseExact(txtIdValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.SocialSecurityNo = txtSocialSecurityNo.Text.Trim();

            objEmp.BankName = txtBankName.Text.Trim();
            objEmp.BankBranch = txtBankBranch.Text.Trim();
            objEmp.BankAccountNo = txtBankAccountNo.Text.Trim();
            objEmp.IBANNo = txtIBANNo.Text.Trim();

            objEmp.PersonalCodeVISA = txtPersonalCodeVISA.Text.Trim();
            objEmp.BankCode = txtBankCode.Text.Trim();
            objEmp.AirportName = txtAirportName.Text.Trim();
            objEmp.DestinationCity = txtDestinationCity.Text.Trim();

            objEmp.EmployerId = txtEmployerId.Text.Trim();
            objEmp.GosiAmount = Convert.ToDecimal(txtGosiAmount.Text.Trim());
            objEmp.IsLocal = (CblIsLocal.SelectedItem.Text=="Yes"?true:false);

            bool Result = objEmp.InsertEmployeeInfo();

            if (Result)
            {
                lblMessage.Text = "Successfully Added!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion InsertEmpInfo

        #region UpdateEmpInfo
        /// <summary>
        /// UpdateEmpInfo
        /// </summary>
        private void UpdateEmpInfo()
        {
            EmpBL objEmp = new EmpBL();

            objEmp.EmpId = ddlEmpId.SelectedItem.Value;
            objEmp.FirstName = txtFirstName.Text.Trim();
            objEmp.MiddleName = txtMiddleName.Text.Trim();
            objEmp.LastName = txtLastName.Text.Trim();

            objEmp.DOB = DateTime.ParseExact(txtDOB.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.Gender = ddlGender.SelectedItem.Value;
            objEmp.PresentAddress = txtPresentAddress.Text.Trim();
            objEmp.PermanentAddress = txtPermanentAddress.Text.Trim();

            objEmp.JoiningDate = DateTime.ParseExact(txtJoiningDate.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            objEmp.MaritalStatus = ddlMaritalStatus.SelectedItem.Value;
            objEmp.Nationality = txtNationality.Text.Trim();
            objEmp.EmpStatus = true;

            objEmp.Phone1 = txtPhoneNo.Text.Trim();
            objEmp.PhoneHomeCountry = txtPhoneHome.Text.Trim();
            objEmp.Email = txtEmail.Text.Trim();
            objEmp.WorkLocation = ddlWorkLocation.SelectedItem.Value;

            objEmp.Designation = ddlDesignation.SelectedItem.Text;
            objEmp.PassportNo = txtPassportNo.Text.Trim();
            objEmp.PassportValidFrom = DateTime.ParseExact(txtPassportValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.PassportValidTill = DateTime.ParseExact(txtPassportValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            objEmp.VisaNo = txtVisaNo.Text;
            objEmp.VisaType = txtVisaType.Text;
            objEmp.VisaValidFrom = DateTime.ParseExact(txtVisaValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.VisaValidTill = DateTime.ParseExact(txtVisaValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            objEmp.IDNo = txtIDNo.Text.Trim();
            objEmp.IDValidFrom = DateTime.ParseExact(txtIDValidFrom.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.IDValidTill = DateTime.ParseExact(txtIdValidTill.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            objEmp.SocialSecurityNo = txtSocialSecurityNo.Text.Trim();

            objEmp.BankName = txtBankName.Text.Trim();
            objEmp.BankBranch = txtBankBranch.Text.Trim();
            objEmp.BankAccountNo = txtBankAccountNo.Text.Trim();
            objEmp.IBANNo = txtIBANNo.Text.Trim();

            objEmp.PersonalCodeVISA = txtPersonalCodeVISA.Text.Trim();
            objEmp.BankCode = txtBankCode.Text.Trim();
            objEmp.AirportName = txtAirportName.Text.Trim();
            objEmp.DestinationCity = txtDestinationCity.Text.Trim();

            objEmp.EmployerId = txtEmployerId.Text.Trim();
            objEmp.GosiAmount = Convert.ToDecimal(txtGosiAmount.Text.Trim());
            objEmp.IsLocal = (CblIsLocal.SelectedItem.Text == "Yes" ? true : false);

            bool Result = objEmp.UpdateEmployeeInfo();

            if (Result)
            {
                lblMessage.Text = "Successfully Updated!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion UpdateEmpInfo

        #region BindEmpId
        /// <summary>
        /// BindEmpId
        /// </summary>
        private void BindEmpId()
        {
            EmpBL objEmp = new EmpBL();
            DataTable dt = objEmp.GetAllEmployeeInfo();
            ddlEmpId.DataSource = dt;
            ddlEmpId.DataMember = "EmpId";
            ddlEmpId.DataValueField = "EmpId";
            ddlEmpId.DataBind();
        }
        #endregion BindEmpId

        #region BindEmpDetails
        /// <summary>
        /// Bind Emp Details
        /// </summary>
        private void BindEmpDetails()
        {
            EmpBL objEmp = new EmpBL();
            objEmp.EmpId = ddlEmpId.SelectedItem.Value;
            DataTable dt = objEmp.GetAllEmployeeInfoByEmpId();

            if(dt.Rows.Count>0)
            {
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtMiddleName.Text = dt.Rows[0]["MiddleName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                txtDOB.Text = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString()).ToShortDateString();

                ddlGender.Text = dt.Rows[0]["Gender"].ToString();
                txtPresentAddress.Text = dt.Rows[0]["PresentAddress"].ToString();
                txtPermanentAddress.Text = dt.Rows[0]["PermanentAddress"].ToString();
                txtJoiningDate.Text = Convert.ToDateTime(dt.Rows[0]["JoiningDate"].ToString()).ToShortDateString();

                ddlMaritalStatus.Text = dt.Rows[0]["MaritalStatus"].ToString();
                txtNationality.Text = dt.Rows[0]["Nationality"].ToString();
                txtPhoneNo.Text = dt.Rows[0]["Phone1"].ToString();
                txtPhoneHome.Text = dt.Rows[0]["Phone(HomeCountry)"].ToString();

                txtEmail.Text = dt.Rows[0]["Email1"].ToString();
                txtDestinationCity.Text = dt.Rows[0]["Designation"].ToString();
                txtPassportNo.Text = dt.Rows[0]["PassportNo"].ToString();
                txtPassportValidFrom.Text = Convert.ToDateTime(dt.Rows[0]["PassportValidFrom"].ToString()).ToShortDateString();

                txtPassportValidTill.Text = Convert.ToDateTime(dt.Rows[0]["PassportValidTill"].ToString()).ToShortDateString();
                txtVisaNo.Text = dt.Rows[0]["VisaNo"].ToString();
                txtVisaType.Text = dt.Rows[0]["VisaType"].ToString();
                txtVisaValidFrom.Text = Convert.ToDateTime(dt.Rows[0]["VisaValidFrom"].ToString()).ToShortDateString();

                txtVisaValidTill.Text = Convert.ToDateTime(dt.Rows[0]["VisaValidTill"].ToString()).ToShortDateString();
                txtIDNo.Text = dt.Rows[0]["IDNo"].ToString();
                txtIDValidFrom.Text = Convert.ToDateTime(dt.Rows[0]["IDValidFrom"].ToString()).ToShortDateString();
                txtIdValidTill.Text = Convert.ToDateTime(dt.Rows[0]["IDValidTill"].ToString()).ToShortDateString();

                txtSocialSecurityNo.Text = dt.Rows[0]["SocialSecurityNo"].ToString();
                txtBankName.Text = dt.Rows[0]["BankName"].ToString();
                txtBankBranch.Text = dt.Rows[0]["BankBranch"].ToString();
                txtBankAccountNo.Text = dt.Rows[0]["BankAccountNo"].ToString();

                txtIBANNo.Text = dt.Rows[0]["IBANNo"].ToString();
                txtPersonalCodeVISA.Text = dt.Rows[0]["PersonalCode(VISA)"].ToString();
                txtBankCode.Text = dt.Rows[0]["BankCode"].ToString();
                txtAirportName.Text = dt.Rows[0]["AirportName"].ToString();

                txtDestinationCity.Text = dt.Rows[0]["DestinationCity"].ToString();
                txtEmployerId.Text = dt.Rows[0]["EmployerId"].ToString();

                string strIsLocal = dt.Rows[0]["IsLocal"].ToString();
               // CblIsLocal.SelectedItem.Value = (strIsLocal == "True")?"1":"0";
               //CblIsLocal.
                txtGosiAmount.Text = dt.Rows[0]["GOSIAmount"].ToString();
                ddlWorkLocation.Text = dt.Rows[0]["WorkLocation"].ToString();
                
             }

        }

        #endregion BindEmpDetails

        #endregion Methods

        
    }
}