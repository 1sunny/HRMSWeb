#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

#endregion NameSpace

namespace HRMSWeb.DAL
{
    public class EmpDAL
    {

        #region Public Properties
        /// <summary>
        /// Exception message
        /// </summary>
        public string ExceptionMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Emp Id
        /// </summary>
        public string EmpId
        {
            get;
            set;
        }
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Middle Name
        /// </summary>
        public string MiddleName
        {
            get;
            set;
        }
        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName
        {
            get;
            set;
        }
        /// <summary>
        /// DOB
        /// </summary>
        public DateTime DOB
        {
            get;
            set;
        }
        /// <summary>
        /// Gender
        /// </summary>
        public string Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Present Address
        /// </summary>
        public string PresentAddress
        {
            get;
            set;
        }
        /// <summary>
        /// Permanent Address
        /// </summary>
        public string PermanentAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Joining Date
        /// </summary>
        public DateTime JoiningDate
        {
            get;
            set;
        }

        /// <summary>
        /// Marital Status
        /// </summary>
        public string MaritalStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Emp Status
        /// </summary>
        public bool EmpStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Id
        /// </summary>
        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Salary Code
        /// </summary>
        public string SalaryCode
        {
            get;
            set;
        }
        /// <summary>
        /// Salary Head
        /// </summary>
        public string SalaryHead
        {
            get;
            set;
        }

        /// <summary>
        /// Salary Amount
        /// </summary>
        public decimal SalaryAmount
        {
            get;
            set;
        }
        /// <summary>
        /// Salary Head Id
        /// </summary>
        public int SalaryHeadId
        {
            get;
            set;
        }

        /// <summary>
        /// Starting Date
        /// </summary>
        public DateTime StartingDate
        {
            get;
            set;
        }

        /// <summary>
        /// DtSource
        /// </summary>
        public DataTable DtSource
        {
            get;
            set;
        }

        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Privilege
        /// </summary>
        public string Privilege
        {
            get;
            set;
        }

        /// <summary>
        /// Punching Time
        /// </summary>
        public DateTime PunchingTime
        {
            get;
            set;
        }

        /// <summary>
        /// Start Time
        /// </summary>
        public TimeSpan StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// End Time
        /// </summary>
        public TimeSpan EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// Is Break Shift
        /// </summary>
        public Boolean IsBreakShift
        {
            get;
            set;
        }

        /// <summary>
        /// ShiftId
        /// </summary>
        public string ShiftId
        {
            get;
            set;
        }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Type
        /// </summary>
        public bool Type
        {
            get;
            set;
        }

        /// <summary>
        /// FromTime
        /// </summary>
        public DateTime FromTime
        {
            get;
            set;
        }

        /// <summary>
        /// ToTime
        /// </summary>
        public DateTime ToTime
        {
            get;
            set;
        }
        /// <summary>
        /// WorkingHours
        /// </summary>
        public int WorkingHours
        {
            get;
            set;
        }
        /// <summary>
        /// Shift Header Id
        /// </summary>
        public string ShiftHeaderId
        {
            get;
            set;
        }
        /// <summary>
        /// Is Midnight Shift
        /// </summary>
        public bool IsMidnightShift
        {
            get;
            set;
        }

        /// <summary>
        /// From Date
        /// </summary>
        public DateTime FromDate
        {
            get;
            set;
        }

        /// <summary>
        /// To Date
        /// </summary>
        public DateTime ToDate
        {
            get;
            set;
        }

        /// <summary>
        /// Month Year
        /// </summary>
        public string MonthYear
        {
            get;
            set;
        }

        /// <summary>
        /// Status
        /// </summary>
        public bool Status
        {
            get;
            set;
        }

        /// <summary>
        /// Check In
        /// </summary>
        public string CheckIn
        {
            get;
            set;
        }

        /// <summary>
        /// Check Out
        /// </summary>
        public string CheckOut
        {
            get;
            set;
        }

        /// <summary>
        /// Worked Time
        /// </summary>
        public string WorkedTime
        {
            get;
            set;
        }
        /// <summary>
        /// Under Time
        /// </summary>
        public string UnderTime
        {
            get;
            set;
        }

        /// <summary>
        /// Over Time
        /// </summary>
        public string OverTime
        {
            get;
            set;
        }

        /// <summary>
        /// Remarks
        /// </summary>
        public string Remarks
        {
            get;
            set;
        }
        /// <summary>
        /// ToEmpId 
        /// </summary>
        public string ToEmpId
        {
            get;
            set;
        }

        /// <summary>
        /// EligibleDays
        /// </summary>
        public int EligibleDays
        {
            get;
            set;
        }

        /// <summary>
        /// DuePeriod
        /// </summary>
        public string DuePeriod
        {
            get;
            set;
        }

        /// <summary>
        /// Ticket DuePeriod
        /// </summary>
        public int TicketDuePeriod
        {
            get;
            set;
        }

        /// <summary>
        /// IsEnable
        /// </summary>
        public bool IsEnable
        {
            get;
            set;
        }
        /// <summary>
        /// Last Month Year
        /// </summary>
        public string LastMonthYear
        {
            get;
            set;
        }
        /// <summary>
        /// Work Location
        /// </summary>
        public string WorkLocation
        {
            get;
            set;
        }

        /// <summary>
        /// StoreLocation
        /// </summary>
        public string StoreLocation
        {
            get;
            set;
        }

        /// <summary>
        /// MonthYear1
        /// </summary>
        public string MonthYear1
        {
            get;
            set;
        }

        /// <summary>
        /// MonthYear2
        /// </summary>
        public string MonthYear2
        {
            get;
            set;
        }

        /// <summary>
        /// MonthYear3
        /// </summary>
        public string MonthYear3
        {
            get;
            set;
        }

        /// <summary>
        /// AsOfDate
        /// </summary>
        public DateTime AsOfDate
        {
            get;
            set;
        }

        /// <summary>
        /// Paid Amount
        /// </summary>
        public Decimal PaidAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Paid Date
        /// </summary>
        public DateTime PaidDate
        {
            get;
            set;
        }

        /// <summary>
        /// Phone1
        /// </summary>
        public string Phone1
        {
            get;
            set;
        }

        /// <summary>
        /// Phone Home Country
        /// </summary>
        public string PhoneHomeCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// Designation
        /// </summary>
        public string Designation
        {
            get;
            set;
        }

        /// <summary>
        /// PassportNo
        /// </summary>
        public string PassportNo
        {
            get;
            set;
        }
        /// <summary>
        /// PassportValidFrom
        /// </summary>
        public DateTime PassportValidFrom
        {
            get;
            set;
        }

        /// <summary>
        /// PassportValidTill
        /// </summary>
        public DateTime PassportValidTill
        {
            get;
            set;
        }
        /// <summary>
        /// VisaNo
        /// </summary>
        public string VisaNo
        {
            get;
            set;
        }
        /// <summary>
        /// VisaType
        /// </summary>
        public string VisaType
        {
            get;
            set;
        }
        /// <summary>
        /// VisaValidFrom
        /// </summary>
        public DateTime VisaValidFrom
        {
            get;
            set;
        }
        /// <summary>
        /// VisaValidTill
        /// </summary>
        public DateTime VisaValidTill
        {
            get;
            set;
        }

        /// <summary>
        /// IDNo
        /// </summary>
        public string IDNo
        {
            get;
            set;
        }
        /// <summary>
        /// IDValidFrom
        /// </summary>
        public DateTime IDValidFrom
        {
            get;
            set;
        }

        /// <summary>
        /// IDValidTill
        /// </summary>
        public DateTime IDValidTill
        {
            get;
            set;
        }

        /// <summary>
        /// SocialSecurityNo
        /// </summary>
        public string SocialSecurityNo
        {
            get;
            set;
        }

        /// <summary>
        /// BankName
        /// </summary>
        public string BankName
        {
            get;
            set;
        }

        /// <summary>
        /// BankBranch
        /// </summary>
        public string BankBranch
        {
            get;
            set;
        }

        /// <summary>
        /// BankAccountNo
        /// </summary>
        public string BankAccountNo
        {
            get;
            set;
        }

        /// <summary>
        /// IBANNo
        /// </summary>
        public string IBANNo
        {
            get;
            set;
        }

        /// <summary>
        /// CreatedDate
        /// </summary>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// PersonalCodeVISA
        /// </summary>
        public string PersonalCodeVISA
        {
            get;
            set;
        }

        /// <summary>
        /// BankCode
        /// </summary>
        public string BankCode
        {
            get;
            set;
        }

        /// <summary>
        /// AirportName
        /// </summary>
        public string AirportName
        {
            get;
            set;
        }

        /// <summary>
        /// DestinationCity
        /// </summary>
        public string DestinationCity
        {
            get;
            set;
        }
        /// <summary>
        /// Nationality
        /// </summary>
        public string Nationality
        {
            get;
            set;
        }
        /// <summary>
        /// EmployerId
        /// </summary>
        public string EmployerId
        {
            get;
            set;
        }

        /// <summary>
        /// CurrentPassword
        /// </summary>
        public string CurrentPassword
        {
            get;
            set;
        }

        /// <summary>
        /// NewPassword
        /// </summary>
        public string NewPassword
        {
            get;
            set;
        }

        /// <summary>
        /// SalaryReasonCode
        /// </summary>
        public string SalaryReasonCode
        {
            get;
            set;
        }

        /// <summary>
        /// BonusPercentage
        /// </summary>
        public int BonusPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Is Local
        /// </summary>
        public bool IsLocal
        {
            get;
            set;
        }

        /// <summary>
        /// Gosi Amount
        /// </summary>
        public decimal GosiAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Schedule Date
        /// </summary>
        public DateTime ScheduleDate
        {
            get;
            set;
        }

        /// <summary>
        /// ReportType
        /// </summary>
        public string ReportType
        {
            get;
            set;
        }

        /// <summary>
        /// MobileNo
        /// </summary>
        public decimal MobileNo
        {
            get;
            set;
        }

        /// <summary>
        /// OfferCode
        /// </summary>
        public string OfferCode
        {
            get;
            set;
        }

        /// <summary>
        /// ValidUntil
        /// </summary>
        public DateTime ValidUntil
        {
            get;
            set;
        }


        #endregion Public Properties


        #region GetEmpInfo
        /// <summary>
        ///  GetEmpInfo
        /// </summary>
        /// <returns>Datatable Containing All GetEmpInfo</returns>
        public DataTable GetEmpInfo()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdTest = new SqlCommand("GetStockStatusReport", cnTest);
                cmdTest.CommandType = CommandType.StoredProcedure;
                //cmdTest.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate;
                //cmdTest.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate;
                //cmdTest.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = Location;

                cmdTest.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdTest);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetEmpInfo


        #region InsertEmployeeInfo
        /// <summary>
        /// InsertEmployeeInfo
        /// </summary>
        /// <returns></returns>

        public bool InsertEmployeeInfo()
        {
            bool Result = false;

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("InsertEmployeeInfo", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = FirstName;
                cmdHrms.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar)).Value = MiddleName;
                cmdHrms.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = LastName;

                cmdHrms.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = DOB;
                cmdHrms.Parameters.Add(new SqlParameter("@Gender", SqlDbType.VarChar)).Value = Gender;
                cmdHrms.Parameters.Add(new SqlParameter("@PresentAddress", SqlDbType.NVarChar)).Value = PresentAddress;
                cmdHrms.Parameters.Add(new SqlParameter("@PermanentAddress", SqlDbType.NVarChar)).Value = PermanentAddress;

                cmdHrms.Parameters.Add(new SqlParameter("@JoiningDate", SqlDbType.DateTime)).Value = JoiningDate;
                cmdHrms.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar)).Value = MaritalStatus;
                cmdHrms.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.VarChar)).Value = Nationality;
                cmdHrms.Parameters.Add(new SqlParameter("@EmpStatus", SqlDbType.Bit)).Value = EmpStatus;
                
                cmdHrms.Parameters.Add(new SqlParameter("@Phone1", SqlDbType.NVarChar)).Value = Phone1;
                cmdHrms.Parameters.Add(new SqlParameter("@PhoneHomeCountry", SqlDbType.NVarChar)).Value = PhoneHomeCountry;
                cmdHrms.Parameters.Add(new SqlParameter("@Email1", SqlDbType.NVarChar)).Value = Email;
                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.NVarChar)).Value = WorkLocation;

                cmdHrms.Parameters.Add(new SqlParameter("@Designation", SqlDbType.NVarChar)).Value = Designation;
                cmdHrms.Parameters.Add(new SqlParameter("@PassportNo", SqlDbType.NVarChar)).Value = PassportNo;
                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidFrom", SqlDbType.DateTime)).Value = PassportValidFrom;
                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidTill", SqlDbType.DateTime)).Value = PassportValidTill;

                cmdHrms.Parameters.Add(new SqlParameter("@VisaNo", SqlDbType.NVarChar)).Value = VisaNo;
                cmdHrms.Parameters.Add(new SqlParameter("@VisaType", SqlDbType.NVarChar)).Value = VisaType;
                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidFrom", SqlDbType.DateTime)).Value = VisaValidFrom;
                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidTill", SqlDbType.DateTime)).Value = VisaValidTill;

                cmdHrms.Parameters.Add(new SqlParameter("@IDNo", SqlDbType.NVarChar)).Value = IDNo;
                cmdHrms.Parameters.Add(new SqlParameter("@IDValidFrom", SqlDbType.DateTime)).Value = IDValidFrom;
                cmdHrms.Parameters.Add(new SqlParameter("@IDValidTill", SqlDbType.DateTime)).Value = IDValidTill;
                cmdHrms.Parameters.Add(new SqlParameter("@SocialSecurityNo", SqlDbType.NVarChar)).Value = SocialSecurityNo;

                cmdHrms.Parameters.Add(new SqlParameter("@BankName", SqlDbType.NVarChar)).Value = BankName;
                cmdHrms.Parameters.Add(new SqlParameter("@BankBranch", SqlDbType.NVarChar)).Value = BankBranch;
                cmdHrms.Parameters.Add(new SqlParameter("@BankAccountNo", SqlDbType.NVarChar)).Value = BankAccountNo;
                cmdHrms.Parameters.Add(new SqlParameter("@IBANNo", SqlDbType.NVarChar)).Value = IBANNo;

                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;
                cmdHrms.Parameters.Add(new SqlParameter("@PersonalCodeVISA", SqlDbType.NVarChar)).Value = PersonalCodeVISA;
                cmdHrms.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.NVarChar)).Value = BankCode;
                cmdHrms.Parameters.Add(new SqlParameter("@AirportName", SqlDbType.NVarChar)).Value = AirportName;

                cmdHrms.Parameters.Add(new SqlParameter("@DestinationCity", SqlDbType.NVarChar)).Value = DestinationCity;
                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
                cmdHrms.Parameters.Add(new SqlParameter("@GosiAmount", SqlDbType.Decimal)).Value = GosiAmount;
                cmdHrms.Parameters.Add(new SqlParameter("@IsLocal", SqlDbType.Bit)).Value = IsLocal;

                cmdHrms.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.VarChar)).Value = "Admin";

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }


        #endregion InsertEmployeeInfo


        #region GetAllEmployeeInfo
        /// <summary>
        ///  GetAllEmployeeInfo
        /// </summary>
        /// <returns>Datatable Containing All GetAllEmployeeInfo</returns>
        public DataTable GetAllEmployeeInfo()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdTest = new SqlCommand("GetAllEmployeeInfo", cnTest);
                cmdTest.CommandType = CommandType.StoredProcedure;

                cmdTest.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdTest);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetAllEmployeeInfo

        #region GetAllEmployeeInfoByEmpId
        /// <summary>
        ///  GetAllEmployeeInfoByEmpId
        /// </summary>
        /// <returns>Datatable Containing All GetAllEmployeeInfoByEmpId</returns>
        public DataTable GetAllEmployeeInfoByEmpId()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetEmployeeInfoByEmpId", cnTest);
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

                cmdHrms.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetAllEmployeeInfoByEmpId

        //#region UpdateEmployeeInfo
        ///// <summary>
        ///// Update Employee Info
        ///// </summary>
        ///// <returns></returns>
        //public bool UpdateEmployeeInfo()
        //{
        //    bool Result = false;

        //    DatabaseConnection dbHrms = new DatabaseConnection();

        //    if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
        //    {
        //        SqlConnection cnHrms = dbHrms.CnDbConnection;

        //        SqlCommand cmdHrms = new SqlCommand("UpdateEmployeeInfo", cnHrms);
        //        cmdHrms.CommandType = CommandType.StoredProcedure;

        //        cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
        //        cmdHrms.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = FirstName;
        //        cmdHrms.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar)).Value = MiddleName;
        //        cmdHrms.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = LastName;

        //        cmdHrms.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = DOB;
        //        cmdHrms.Parameters.Add(new SqlParameter("@Gender", SqlDbType.VarChar)).Value = Gender;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PresentAddress", SqlDbType.NVarChar)).Value = PresentAddress;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PermanentAddress", SqlDbType.NVarChar)).Value = PermanentAddress;

        //        cmdHrms.Parameters.Add(new SqlParameter("@JoiningDate", SqlDbType.DateTime)).Value = JoiningDate;
        //        cmdHrms.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar)).Value = MaritalStatus;
        //        cmdHrms.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.VarChar)).Value = Nationality;
        //        cmdHrms.Parameters.Add(new SqlParameter("@EmpStatus", SqlDbType.Bit)).Value = EmpStatus;

        //        cmdHrms.Parameters.Add(new SqlParameter("@Phone1", SqlDbType.NVarChar)).Value = Phone1;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PhoneHomeCountry", SqlDbType.NVarChar)).Value = PhoneHomeCountry;
        //        cmdHrms.Parameters.Add(new SqlParameter("@Email1", SqlDbType.NVarChar)).Value = Email;
        //        cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.NVarChar)).Value = WorkLocation;

        //        cmdHrms.Parameters.Add(new SqlParameter("@Designation", SqlDbType.NVarChar)).Value = Designation;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PassportNo", SqlDbType.NVarChar)).Value = PassportNo;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PassportValidFrom", SqlDbType.DateTime)).Value = PassportValidFrom;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PassportValidTill", SqlDbType.DateTime)).Value = PassportValidTill;

        //        cmdHrms.Parameters.Add(new SqlParameter("@VisaNo", SqlDbType.NVarChar)).Value = VisaNo;
        //        cmdHrms.Parameters.Add(new SqlParameter("@VisaType", SqlDbType.NVarChar)).Value = VisaType;
        //        cmdHrms.Parameters.Add(new SqlParameter("@VisaValidFrom", SqlDbType.DateTime)).Value = VisaValidFrom;
        //        cmdHrms.Parameters.Add(new SqlParameter("@VisaValidTill", SqlDbType.DateTime)).Value = VisaValidTill;

        //        cmdHrms.Parameters.Add(new SqlParameter("@IDNo", SqlDbType.NVarChar)).Value = IDNo;
        //        cmdHrms.Parameters.Add(new SqlParameter("@IDValidFrom", SqlDbType.DateTime)).Value = IDValidFrom;
        //        cmdHrms.Parameters.Add(new SqlParameter("@IDValidTill", SqlDbType.DateTime)).Value = IDValidTill;
        //        cmdHrms.Parameters.Add(new SqlParameter("@SocialSecurityNo", SqlDbType.NVarChar)).Value = SocialSecurityNo;

        //        cmdHrms.Parameters.Add(new SqlParameter("@BankName", SqlDbType.NVarChar)).Value = BankName;
        //        cmdHrms.Parameters.Add(new SqlParameter("@BankBranch", SqlDbType.NVarChar)).Value = BankBranch;
        //        cmdHrms.Parameters.Add(new SqlParameter("@BankAccountNo", SqlDbType.NVarChar)).Value = BankAccountNo;
        //        cmdHrms.Parameters.Add(new SqlParameter("@IBANNo", SqlDbType.NVarChar)).Value = IBANNo;

        //        cmdHrms.Parameters.Add(new SqlParameter("@ModifiedDate", SqlDbType.DateTime)).Value = DateTime.Now;
        //        cmdHrms.Parameters.Add(new SqlParameter("@PersonalCodeVISA", SqlDbType.NVarChar)).Value = PersonalCodeVISA;
        //        cmdHrms.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.NVarChar)).Value = BankCode;
        //        cmdHrms.Parameters.Add(new SqlParameter("@AirportName", SqlDbType.NVarChar)).Value = AirportName;

        //        cmdHrms.Parameters.Add(new SqlParameter("@DestinationCity", SqlDbType.NVarChar)).Value = DestinationCity;
        //        cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
        //        cmdHrms.Parameters.Add(new SqlParameter("@GosiAmount", SqlDbType.Decimal)).Value = GosiAmount;
        //        cmdHrms.Parameters.Add(new SqlParameter("@IsLocal", SqlDbType.Bit)).Value = IsLocal;

        //        cmdHrms.Parameters.Add(new SqlParameter("@ModifiedBy", SqlDbType.VarChar)).Value = "Admin";

        //        cmdHrms.CommandTimeout = 0;

        //        try
        //        {
        //            Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
        //            ExceptionMessage = "";
        //        }
        //        catch (SqlException ex)
        //        {
        //            ExceptionMessage = ex.Message;
        //        }

        //        finally
        //        {
        //            dbHrms.CloseDbConnection();
        //        }
        //    }
        //    else
        //    {
        //        ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
        //    }

        //    return Result;
        //}

        //#endregion UpdateEmployeeInfo

        #region GetScheduleImportData
        /// <summary>
        ///  GetScheduleImportData
        /// </summary>
        /// <returns>Datatable Containing All GetScheduleImportData</returns>
        public DataTable GetScheduleImportData()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetScheduleImportData", cnTest);
               // cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.Date)).Value = FromDate;
               // cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.Date)).Value =ToDate;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;

                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetScheduleImportData


        #region GetShiftMaster
        /// <summary>
        ///  Get Shift Master
        /// </summary>
        /// <returns>Datatable Containing All GetShiftMaster</returns>
        public DataTable GetShiftMaster()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetShiftMaster", cnTest);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.CommandTimeout = 0;
                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetShiftMaster

        #region Save Schedule
        /// <summary>
        ///SaveSchedule
        /// </summary>
        /// <param name="dtSource"></param>
        public bool SaveSchedule()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbHrms = new DatabaseConnection();

                string dbCntStr = dbHrms.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "EmployeeShedule";

                bcp.ColumnMappings.Add("EmpId", "EmpId");
                bcp.ColumnMappings.Add("ShiftId", "ShiftId");
                bcp.ColumnMappings.Add("Date", "Date");
                bcp.ColumnMappings.Add("Location", "Location");

                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    //dbHrms.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {


                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion Save Schedule


        #region GetEmpSchedule
        /// <summary>
        ///  GetEmpSchedule
        /// </summary>
        /// <returns>Datatable Containing All GetEmpSchedule</returns>
        public DataTable GetEmpSchedule()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetEmployeeSchedule", cnTest);

                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.Date)).Value = FromDate.Date;
                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.Date)).Value = ToDate.Date;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetEmpSchedule

        #region GetAttendance
        /// <summary>
        ///  GetAttendance
        /// </summary>
        /// <returns>Datatable Containing All GetAttendance</returns>
        public DataTable GetAttendance()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("Cur_GetAttendanceReportInRange", cnTest);

                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.Date)).Value = FromDate;
                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.Date)).Value = ToDate;
                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;

                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetAttendance

        #region GetRemarks
        /// <summary>
        ///  GetRemarks
        /// </summary>
        /// <returns>Datatable Containing All GetRemarks</returns>
        public DataTable GetRemarks()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetRemarks", cnTest);

                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetRemarks


        #region GetLogin
        /// <summary>
        ///  GetLogin
        /// </summary>
        /// <returns>Datatable Containing All GetLogin</returns>
        public DataTable GetLogin()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetLogin", cnTest);

                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.NVarChar)).Value = EmpId;
                cmdHrms.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar)).Value = Password;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetLogin


        #region Save Attendance
        /// <summary>
        ///Save Attendance
        /// </summary>
        /// <param name="dtSource"></param>
        public bool SaveAttendance()
        {
            bool Result = false;
            try
            {
                DatabaseConnection dbHrms = new DatabaseConnection();

                string dbCntStr = dbHrms.dbCntStr;

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

                bcp.DestinationTableName = "AttendanceReportLine";


                bcp.ColumnMappings.Add("Date", "Date");
                bcp.ColumnMappings.Add("EmpId", "EmpId");
                bcp.ColumnMappings.Add("ShiftId", "ShiftId");
                bcp.ColumnMappings.Add("EmpName", "EmpName");

                bcp.ColumnMappings.Add("CheckIn", "CheckIn");
                bcp.ColumnMappings.Add("CheckOut", "CheckOut");
                bcp.ColumnMappings.Add("BreakOut", "BreakOut");
                bcp.ColumnMappings.Add("BreakIn", "BreakIn");

                bcp.ColumnMappings.Add("BreakTime", "BreakTime");
                bcp.ColumnMappings.Add("SchIn", "SchIn");
                bcp.ColumnMappings.Add("SchOut", "SchOut");
                bcp.ColumnMappings.Add("UnderTime", "UnderTime");

                bcp.ColumnMappings.Add("OwedHours", "OwedHours");
                bcp.ColumnMappings.Add("SystemRemarks", "SystemRemarks");
                bcp.ColumnMappings.Add("L1Approve", "L1Approve");
                bcp.ColumnMappings.Add("L1Remarks", "L1Remarks");

                bcp.ColumnMappings.Add("L2Approve", "L2Approve");
                bcp.ColumnMappings.Add("L2Remarks", "L2Remarks");
                bcp.ColumnMappings.Add("OHAdj", "OHAdj");
                bcp.ColumnMappings.Add("UTAdj", "UTAdj");

                bcp.ColumnMappings.Add("StoreLocation", "StoreLocation");
                bcp.ColumnMappings.Add("WorkedTime", "WorkedTime");


                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                    Result = true;
                    //dbHrms.CloseDbConnection();
                }
            }
            catch (SqlException ex)
            {


                ExceptionMessage = ex.Message;
            }

            return Result;

        }
        #endregion Save Attendance


        #region UpdateAttendaceReportLine
        /// <summary>
        /// Update HR Attendace ReportLine
        /// </summary>
        /// <param name="dtSalaryReport"></param>
        public bool UpdateAttendaceReportLine()
        {
            DatabaseConnection dbHrms = new DatabaseConnection();
            bool Result = false;
            using (SqlConnection conn = dbHrms.CnDbConnection)
            {
                using (SqlCommand command = new SqlCommand("", conn))
                {
                    try
                    {
                        //Creating temp table on database
                        command.CommandText = "CREATE TABLE #TmpTable(Id int,EmpId varchar(10),L2Remarks varchar(MAX),L2Approve bit)";
                        //MonthYear varchar(15)
                        command.ExecuteNonQuery();

                        //Bulk insert into temp table
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
                        {
                            bulkcopy.BulkCopyTimeout = 660;
                            bulkcopy.DestinationTableName = "#TmpTable";
                            bulkcopy.WriteToServer(DtSource);
                            bulkcopy.Close();
                        }

                        // Updating destination table, and dropping temp table
                        command.CommandTimeout = 500;
                        command.CommandText = "UPDATE T SET L2Remarks=Temp.L2Remarks,L2Approve=Temp.L2Approve  FROM AttendanceReportLine  T INNER JOIN #TmpTable Temp ON  T.EmpId=Temp.EmpId COLLATE DATABASE_DEFAULT and T.Id=Temp.Id; DROP TABLE #TmpTable;";
                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

                    }
                    catch (Exception ex)
                    {
                        // Handle exception properly
                        // MessageBox.Show("Level2 Checking Failed.");
                    }
                    finally
                    {
                        dbHrms.CloseDbConnection();
                    }
                }
            }

            return Result;
        }
        #endregion UpdateHRAttendaceReportLine


        #region GetAttendanceLine
        /// <summary>
        ///  GetAttendanceLine
        /// </summary>
        /// <returns>Datatable Containing All GetAttendanceLine</returns>
        public DataTable GetAttendanceLine()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetAttendanceLine", cnTest);

                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate.Date;
                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate.Date;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;

                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetAttendanceLine

        #region GetAttendanceByDate
        /// <summary>
        ///  GetAttendanceByDate
        /// </summary>
        /// <returns>Datatable Containing All GetAttendanceByDate</returns>
        public DataTable GetAttendanceByDate()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnTest = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetAttendanceLineByDate", cnTest);

                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@ReportDate", SqlDbType.DateTime)).Value = Date;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
                cmdHrms.Parameters.Add(new SqlParameter("@ReportType", SqlDbType.VarChar)).Value = ReportType;

                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetAttendanceByDate

        #region Get Server Date
        /// <summary>
        /// Get Server Date
        /// </summary>
        /// <returns></returns>
        public DataTable GetServerDate()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetServerDate", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }
                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion Get Server Date

        #region ImportEmployeeData
        /// <summary>
        /// Import Employee Data
        /// </summary>
        /// <param name="dtSource"></param>
        public void ImportEmployeeData()
        {

            try
            {

                DatabaseConnection dbConn = new DatabaseConnection();

                SqlConnection cnTest = dbConn.CnDbConnection;
                //SqlCommand cmdTest = new SqlCommand("Delete[ContainerExtract] where [Container Reference] = '"+ContainerNo+"'", cnTest);
                //cmdTest.ExecuteNonQuery();

                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbConn.dbCntStr);//add connectionstring here

                bcp.DestinationTableName = "EmployeeInfo";//give destination table name

                bcp.ColumnMappings.Add("EmpId", "EmpId");//Map all columns
                bcp.ColumnMappings.Add("FPId", "FPId");
                bcp.ColumnMappings.Add("Name", "Name");
                bcp.ColumnMappings.Add("DOB", "DOB");

                bcp.ColumnMappings.Add("Gender", "Gender");
                bcp.ColumnMappings.Add("JoiningDate", "JoiningDate");
                bcp.ColumnMappings.Add("IsLogin", "IsLogin");
                bcp.ColumnMappings.Add("Password", "Password");

                bcp.ColumnMappings.Add("Privilege", "Privilege");
                bcp.ColumnMappings.Add("Location", "Location");
                bcp.ColumnMappings.Add("Status", "Status");
              
                // and so on...., maap all source table with your destination table
                if (DtSource.Rows.Count > 0)
                {
                    bcp.WriteToServer(DtSource);
                }
            }
            catch (SqlException ex)
            {
                ExceptionMessage = ex.Message;
            }
        }

        #endregion ImportEmployeeData

        #region Get Store
        /// <summary>
        /// Get Store
        /// </summary>
        /// <returns></returns>
        public DataTable GetStore()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetStore", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }
                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetStore

        #region GetEmpDetailsById
        /// <summary>
        /// Get Emp Details By Id
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmpDetailsById()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetEmpInfoById", cnHrms);
                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }
                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion GetEmpDetailsById


        #region UpdateEmployeeInfo
        /// <summary>
        /// Update Employee Info
        /// </summary>
        /// <returns></returns>
        public bool UpdateEmployeeInfo()
        {
            bool Result = false;

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("UpdateEmployeeInfo", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = StoreLocation;
                cmdHrms.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)).Value = EmpStatus;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }

        #endregion UpdateEmployeeInfo


        #region InsertOffer
        /// <summary>
        /// InsertOffer
        /// </summary>
        /// <returns></returns>
        public bool InsertOffer()
        {
            bool Result = false;

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("InsertOffer", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;
                
                cmdHrms.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar)).Value = OfferCode;
                cmdHrms.Parameters.Add(new SqlParameter("@MobileNo", SqlDbType.BigInt)).Value = MobileNo ;
                cmdHrms.Parameters.Add(new SqlParameter("@ValidUntil", SqlDbType.Date)).Value = ValidUntil;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }
        #endregion InsertOffer

        #region Get Customer
        /// <summary>
        /// Get Customer
        /// </summary>
        /// <returns></returns>
        public DataTable GetCustomer()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetCustomerDetails", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }
                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion Get Customer

        #region Get Offer Code
        /// <summary>
        /// Get Offer Code
        /// </summary>
        /// <returns></returns>
        public DataTable GetOfferCode()
        {
            DataTable dtHrms = new DataTable();

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("GetOfferCode", cnHrms);
                cmdHrms.Parameters.Add(new SqlParameter("@MobileNo", SqlDbType.BigInt)).Value = MobileNo;
                cmdHrms.CommandType = CommandType.StoredProcedure;
                cmdHrms.CommandTimeout = 0;

                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
                try
                {
                    daStock.Fill(dtHrms);
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }
                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return dtHrms;
        }
        #endregion Get Offer Code


        #region UpdateOffer
        /// <summary>
        /// Update Offer
        /// </summary>
        /// <returns></returns>
        public bool UpdateOffer()
        {
            bool Result = false;

            DatabaseConnection dbHrms = new DatabaseConnection();

            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
            {
                SqlConnection cnHrms = dbHrms.CnDbConnection;

                SqlCommand cmdHrms = new SqlCommand("UpdateOffer", cnHrms);
                cmdHrms.CommandType = CommandType.StoredProcedure;

                cmdHrms.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar)).Value = OfferCode;
                cmdHrms.Parameters.Add(new SqlParameter("@MobileNo", SqlDbType.BigInt)).Value = MobileNo;
                cmdHrms.Parameters.Add(new SqlParameter("@StoreNo", SqlDbType.VarChar)).Value = StoreLocation;

                cmdHrms.CommandTimeout = 0;

                try
                {
                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
                    ExceptionMessage = "";
                }
                catch (SqlException ex)
                {
                    ExceptionMessage = ex.Message;
                }

                finally
                {
                    dbHrms.CloseDbConnection();
                }
            }
            else
            {
                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
            }

            return Result;
        }
        #endregion UpdateOffer
    }
}