
//#region NameSpace
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;
//using MatalanHrms.BAL;
////using MatalanHrms.BAL;
//using HRMSWeb.DAL;
//#endregion NameSpace


//namespace HRMSWeb.DAL
//{
//    public class TestEmp
//    {
//        #region Public Properties
//        /// <summary>
//        /// Exception message
//        /// </summary>
//        public string ExceptionMessage
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Emp Id
//        /// </summary>
//        public string EmpId
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// First Name
//        /// </summary>
//        public string FirstName
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Middle Name
//        /// </summary>
//        public string MiddleName
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Last Name
//        /// </summary>
//        public string LastName
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// DOB
//        /// </summary>
//        public DateTime DOB
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Gender
//        /// </summary>
//        public string Gender
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Present Address
//        /// </summary>
//        public string PresentAddress
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Permanent Address
//        /// </summary>
//        public string PermanentAddress
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Joining Date
//        /// </summary>
//        public DateTime JoiningDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Marital Status
//        /// </summary>
//        public string MaritalStatus
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Emp Status
//        /// </summary>
//        public bool EmpStatus
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Id
//        /// </summary>
//        public int Id
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Salary Code
//        /// </summary>
//        public string SalaryCode
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Salary Head
//        /// </summary>
//        public string SalaryHead
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Salary Amount
//        /// </summary>
//        public decimal SalaryAmount
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Salary Head Id
//        /// </summary>
//        public int SalaryHeadId
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Starting Date
//        /// </summary>
//        public DateTime StartingDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// DtSource
//        /// </summary>
//        public DataTable DtSource
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Password
//        /// </summary>
//        public string Password
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Privilege
//        /// </summary>
//        public string Privilege
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Punching Time
//        /// </summary>
//        public DateTime PunchingTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Start Time
//        /// </summary>
//        public TimeSpan StartTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// End Time
//        /// </summary>
//        public TimeSpan EndTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Is Break Shift
//        /// </summary>
//        public Boolean IsBreakShift
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// ShiftId
//        /// </summary>
//        public string ShiftId
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Date
//        /// </summary>
//        public DateTime Date
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Type
//        /// </summary>
//        public bool Type
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// FromTime
//        /// </summary>
//        public DateTime FromTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// ToTime
//        /// </summary>
//        public DateTime ToTime
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// WorkingHours
//        /// </summary>
//        public int WorkingHours
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Shift Header Id
//        /// </summary>
//        public string ShiftHeaderId
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Is Midnight Shift
//        /// </summary>
//        public bool IsMidnightShift
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// From Date
//        /// </summary>
//        public DateTime FromDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// To Date
//        /// </summary>
//        public DateTime ToDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Month Year
//        /// </summary>
//        public string MonthYear
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Status
//        /// </summary>
//        public bool Status
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Check In
//        /// </summary>
//        public string CheckIn
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Check Out
//        /// </summary>
//        public string CheckOut
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Worked Time
//        /// </summary>
//        public string WorkedTime
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Under Time
//        /// </summary>
//        public string UnderTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Over Time
//        /// </summary>
//        public string OverTime
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Remarks
//        /// </summary>
//        public string Remarks
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// ToEmpId 
//        /// </summary>
//        public string ToEmpId
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// EligibleDays
//        /// </summary>
//        public int EligibleDays
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// DuePeriod
//        /// </summary>
//        public string DuePeriod
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Ticket DuePeriod
//        /// </summary>
//        public int TicketDuePeriod
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// IsEnable
//        /// </summary>
//        public bool IsEnable
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Last Month Year
//        /// </summary>
//        public string LastMonthYear
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Work Location
//        /// </summary>
//        public string WorkLocation
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// StoreLocation
//        /// </summary>
//        public string StoreLocation
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// MonthYear1
//        /// </summary>
//        public string MonthYear1
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// MonthYear2
//        /// </summary>
//        public string MonthYear2
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// MonthYear3
//        /// </summary>
//        public string MonthYear3
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// AsOfDate
//        /// </summary>
//        public DateTime AsOfDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Paid Amount
//        /// </summary>
//        public Decimal PaidAmount
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Paid Date
//        /// </summary>
//        public DateTime PaidDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Phone1
//        /// </summary>
//        public string Phone1
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Phone Home Country
//        /// </summary>
//        public string PhoneHomeCountry
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Email
//        /// </summary>
//        public string Email
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Designation
//        /// </summary>
//        public string Designation
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// PassportNo
//        /// </summary>
//        public string PassportNo
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// PassportValidFrom
//        /// </summary>
//        public DateTime PassportValidFrom
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// PassportValidTill
//        /// </summary>
//        public DateTime PassportValidTill
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// VisaNo
//        /// </summary>
//        public string VisaNo
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// VisaType
//        /// </summary>
//        public string VisaType
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// VisaValidFrom
//        /// </summary>
//        public DateTime VisaValidFrom
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// VisaValidTill
//        /// </summary>
//        public DateTime VisaValidTill
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// IDNo
//        /// </summary>
//        public string IDNo
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// IDValidFrom
//        /// </summary>
//        public DateTime IDValidFrom
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// IDValidTill
//        /// </summary>
//        public DateTime IDValidTill
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// SocialSecurityNo
//        /// </summary>
//        public string SocialSecurityNo
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// BankName
//        /// </summary>
//        public string BankName
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// BankBranch
//        /// </summary>
//        public string BankBranch
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// BankAccountNo
//        /// </summary>
//        public string BankAccountNo
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// IBANNo
//        /// </summary>
//        public string IBANNo
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// CreatedDate
//        /// </summary>
//        public DateTime CreatedDate
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// PersonalCodeVISA
//        /// </summary>
//        public string PersonalCodeVISA
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// BankCode
//        /// </summary>
//        public string BankCode
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// AirportName
//        /// </summary>
//        public string AirportName
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// DestinationCity
//        /// </summary>
//        public string DestinationCity
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// Nationality
//        /// </summary>
//        public string Nationality
//        {
//            get;
//            set;
//        }
//        /// <summary>
//        /// EmployerId
//        /// </summary>
//        public string EmployerId
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// CurrentPassword
//        /// </summary>
//        public string CurrentPassword
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// NewPassword
//        /// </summary>
//        public string NewPassword
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// SalaryReasonCode
//        /// </summary>
//        public string SalaryReasonCode
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// BonusPercentage
//        /// </summary>
//        public int BonusPercentage
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Is Local
//        /// </summary>
//        public bool IsLocal
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Gosi Amount
//        /// </summary>
//        public decimal GosiAmount
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Description
//        /// </summary>
//        public string Description
//        {
//            get;
//            set;
//        }

//        /// <summary>
//        /// Schedule Date
//        /// </summary>
//        public DateTime ScheduleDate
//        {
//            get;
//            set;
//        }


//        #endregion Public Properties

//        #region GetEmployeeInfo
//        /// <summary>
//        ///  Get Employee Info
//        /// </summary>
//        /// <returns>Datatable Containing All Employee Info</returns>
//        public DataTable GetEmployeeInfo()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmployeeInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetEmployeeInfo

//        #region Get Employee Info By Id
//        /// <summary>
//        ///  Get Employee Info ById
//        /// </summary>
//        /// <returns>Datatable Containing All Employee Info</returns>
//        public DataTable GetEmployeeInfoById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmployeeInfoById", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Employee Info By Id

//        #region Get Salary Head
//        /// <summary>
//        ///  Get Salary Head
//        /// </summary>
//        /// <returns>Datatable Containing All Salary Head</returns>
//        public DataTable GetSalaryHead()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetSalaryHead", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryCode", SqlDbType.VarChar)).Value = SalaryCode;

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Salary Head

//        #region GetEmpSalary
//        /// <summary>
//        ///  Get Emp Salary
//        /// </summary>
//        /// <returns>Datatable Containing All Emp Salary</returns>
//        public DataTable GetEmpSalary()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpSalary", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetEmpSalary

//        #region Check Employee Existing
//        /// <summary>
//        ///  Check Employee Existing
//        /// </summary>
//        /// <returns>Datatable Containing All Employee Info</returns>
//        public DataTable CheckEmployeeExisting()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("CheckEmpExisting", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Check Employee Existing

//        #region Insert Employee Info
//        /// <summary>
//        /// Insert Employee Info
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertEmployeeInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertEmployeeInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = FirstName;
//                cmdHrms.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar)).Value = MiddleName;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = LastName;

//                cmdHrms.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = DOB;
//                cmdHrms.Parameters.Add(new SqlParameter("@Gender", SqlDbType.VarChar)).Value = Gender;
//                cmdHrms.Parameters.Add(new SqlParameter("@PresentAddress", SqlDbType.NVarChar)).Value = PresentAddress;
//                cmdHrms.Parameters.Add(new SqlParameter("@PermanentAddress", SqlDbType.NVarChar)).Value = PermanentAddress;

//                cmdHrms.Parameters.Add(new SqlParameter("@JoiningDate", SqlDbType.DateTime)).Value = JoiningDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar)).Value = MaritalStatus;
//                cmdHrms.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.VarChar)).Value = Nationality;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpStatus", SqlDbType.Bit)).Value = EmpStatus;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Insert Employee Info

//        #region Delete Employee Info
//        /// <summary>
//        /// Delete Employee Info
//        /// </summary>
//        /// <returns></returns>
//        public bool DeleteEmployeeInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("DeleteEmployeeInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Delete Employee Info

//        #region Update Employee Info
//        /// <summary>
//        ///Update Employee Info
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateEmployeeInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("UpdateEmployeeInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = Id;
//                cmdHrms.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar)).Value = FirstName;
//                cmdHrms.Parameters.Add(new SqlParameter("@MiddleName", SqlDbType.NVarChar)).Value = MiddleName;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar)).Value = LastName;

//                cmdHrms.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime)).Value = DOB;
//                cmdHrms.Parameters.Add(new SqlParameter("@Gender", SqlDbType.VarChar)).Value = Gender;
//                cmdHrms.Parameters.Add(new SqlParameter("@PresentAddress", SqlDbType.NVarChar)).Value = PresentAddress;
//                cmdHrms.Parameters.Add(new SqlParameter("@PermanentAddress", SqlDbType.NVarChar)).Value = PermanentAddress;

//                cmdHrms.Parameters.Add(new SqlParameter("@JoiningDate", SqlDbType.DateTime)).Value = JoiningDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@Nationality", SqlDbType.NVarChar)).Value = Nationality;
//                cmdHrms.Parameters.Add(new SqlParameter("@MaritalStatus", SqlDbType.VarChar)).Value = MaritalStatus;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpStatus", SqlDbType.VarChar)).Value = EmpStatus;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Update Employee Info

//        #region Insert Salary Head
//        /// <summary>
//        ///Insert Salary Head
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertSalaryHead()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertSalaryHead", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryCode", SqlDbType.VarChar)).Value = SalaryCode;
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryHead", SqlDbType.NVarChar)).Value = SalaryHead;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;
//                cmdHrms.Parameters.Add(new SqlParameter("@IsEnable", SqlDbType.Bit)).Value = true;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Insert Salary Head

//        #region Insert Emp Salary Info
//        /// <summary>
//        ///Insert Emp Salary Info
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertEmpSalaryInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertSalaryHead", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryHeadId", SqlDbType.Int)).Value = SalaryHeadId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal)).Value = SalaryAmount;
//                cmdHrms.Parameters.Add(new SqlParameter("@StartingDate", SqlDbType.DateTime)).Value = StartingDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@IsEnable", SqlDbType.Bit)).Value = true;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Insert Emp Salary Info

//        #region BulkInsert
//        /// <summary>
//        /// Bult Insert
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool BulkInsert()
//        {
//            bool Result = false;
//            try
//            {

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);//add connectionstring here


//                bcp.DestinationTableName = "EmpSalary";//give destination table name

//                bcp.ColumnMappings.Add("column0", "SalaryHeadId");

//                bcp.ColumnMappings.Add("column1", "EmpId");//Map all columns



//                bcp.ColumnMappings.Add("column4", "Amount");

//                bcp.ColumnMappings.Add("column5", "CreatedDate");

//                //bcp.ColumnMappings.Add("IsEnable", 1);



//                DtSource.Columns.Remove("column2");
//                DtSource.Columns.Remove("column3");


//                // and so on...., maap all source table with your destination table
//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    //dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;

//            }

//            return Result;

//        }

//        #endregion BulkInsert

//        #region CheckEmpSalaryExisting
//        /// <summary>
//        ///  CheckEmpSalaryExisting
//        /// </summary>
//        /// <returns>Datatable Containing All Emp Salary</returns>
//        public DataTable CheckEmpSalaryExisting()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("CheckEmpSalaryExisting", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@StartingDate", SqlDbType.DateTime)).Value = StartingDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@HeadId", SqlDbType.Int)).Value = SalaryHeadId;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion CheckEmpSalaryExisting

//        #region GetLoginDetails
//        /// <summary>
//        ///  Get Login Details
//        /// </summary>
//        /// <returns>Datatable Containing Login Details</returns>
//        public DataTable GetLoginDetails()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetLoginDetails", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar)).Value = Password;

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetLoginDetails

//        #region Insert User Details
//        /// <summary>
//        ///Insert User Details
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertUserDetails()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertUserLogins", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar)).Value = Password;
//                cmdHrms.Parameters.Add(new SqlParameter("@Privilege", SqlDbType.NVarChar)).Value = Privilege;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedId", SqlDbType.VarChar)).Value = Common.EmpId;

//                cmdHrms.Parameters.Add(new SqlParameter("@LastUpdatedId", SqlDbType.VarChar)).Value = Common.EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastUpdatedDate", SqlDbType.Date)).Value = DateTime.Now;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.Date)).Value = DateTime.Now;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Insert User Details

//        #region GetUserDetailsById
//        /// <summary>
//        ///  Get User Details By Id
//        /// </summary>
//        /// <returns>Datatable Containing User Details</returns>
//        public DataTable GetUserDetailsById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetUserDetailsById", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetUserDetailsById

//        #region Update User Details
//        /// <summary>
//        ///Update User Details
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateUserDetails()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("UpdateUserLogin", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar)).Value = Password;
//                cmdHrms.Parameters.Add(new SqlParameter("@Privilege", SqlDbType.NVarChar)).Value = Privilege;

//                cmdHrms.Parameters.Add(new SqlParameter("@LastUpdatedId", SqlDbType.VarChar)).Value = Common.EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastUpdatedDate", SqlDbType.Date)).Value = DateTime.Now;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion Update User Details

//        #region ImportAttendanceData
//        /// <summary>
//        ///Import Attendance Data
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportAttendanceData()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();

//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "AttendanceInfo";
//                bcp.ColumnMappings.Add("No.", "EmpId");
//                bcp.ColumnMappings.Add("Time", "PunchingTime");
//                // bcp.ColumnMappings.Add("Type", "Type");

//                bcp.ColumnMappings.Add("Machines Name", "MachineName");
//                bcp.ColumnMappings.Add("State", "CheckInOut");
//                // bcp.ColumnMappings.Add("ShiftId", "ShiftId");
//                bcp.ColumnMappings.Add("CreatedDate", "CreatedDate");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }

//        #endregion ImportAttendanceData

//        #region ImportEmployeeSalaryData
//        /// <summary>
//        ///Import Employee Salary Data
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportEmployeeSalaryData()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();


//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;



//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "EmpSalary";


//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("SalaryHeadId", "SalaryHeadId");
//                bcp.ColumnMappings.Add("Amount", "Amount");
//                bcp.ColumnMappings.Add("CreatedDate", "CreatedDate");

//                DataColumnCollection columns = DtSource.Columns;

//                if (columns.Contains("SalaryCode"))
//                {
//                    DtSource.Columns.Remove("SalaryCode");
//                }

//                if (columns.Contains("SalaryCode"))
//                {
//                    DtSource.Columns.Remove("SalaryDesc");
//                }

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion ImportEmployeeSalaryData

//        #region ImportVacationData
//        /// <summary>
//        ///Import Vacation Data
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportVacationData()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();

//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //    ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "VacationInfo";

//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("EligibleDays", "EligibleDays");
//                bcp.ColumnMappings.Add("DuePeriod", "DuePeriod");
//                bcp.ColumnMappings.Add("StartingDate", "StartingDate");

//                bcp.ColumnMappings.Add("IsEnable", "IsEnable");
//                bcp.ColumnMappings.Add("TicketDuePeriod", "TicketDuePeriod");


//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion ImportVacationData


//        #region Import Employee Info
//        /// <summary>
//        ///Import Employee Information
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportEmployeeInfo()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "EmployeeInfo";

//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("FirstName", "FirstName");
//                bcp.ColumnMappings.Add("MiddleName", "MiddleName");
//                bcp.ColumnMappings.Add("LastName", "LastName");

//                bcp.ColumnMappings.Add("DOB", "DOB");
//                bcp.ColumnMappings.Add("Gender", "Gender");
//                bcp.ColumnMappings.Add("PresentAddress", "PresentAddress");
//                bcp.ColumnMappings.Add("PermanentAddress", "PermanentAddress");

//                bcp.ColumnMappings.Add("JoiningDate", "JoiningDate");
//                bcp.ColumnMappings.Add("MaritalStatus", "MaritalStatus");
//                bcp.ColumnMappings.Add("EmpStatus", "EmpStatus");
//                bcp.ColumnMappings.Add("Nationality", "Nationality");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Import Employee Info

//        #region Import Attendance Line
//        /// <summary>
//        ///Import Attendance Line
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportAttendanceLine()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();

//                string dbCntStr = dbHrms.dbCntStr;

//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "AttendanceReportLine";

//                bcp.ColumnMappings.Add("Date", "Date");
//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("EmpName", "EmpName");
//                bcp.ColumnMappings.Add("ShiftId", "ShiftId");

//                bcp.ColumnMappings.Add("CheckIn1", "CheckIn");
//                bcp.ColumnMappings.Add("CheckOut1", "CheckOut");

//                bcp.ColumnMappings.Add("BreakOut1", "BreakOut");
//                bcp.ColumnMappings.Add("BreakIn1", "BreakIn");
//                bcp.ColumnMappings.Add("BreakTime", "BreakTime");

//                bcp.ColumnMappings.Add("SchIn1", "SchIn");
//                bcp.ColumnMappings.Add("SchOut1", "SchOut");

//                bcp.ColumnMappings.Add("WorkedTime", "WorkedTime");
//                bcp.ColumnMappings.Add("UnderTime", "UnderTime");
//                bcp.ColumnMappings.Add("OverTime", "OverTime");
//                bcp.ColumnMappings.Add("Remarks", "Remarks");

//                bcp.ColumnMappings.Add("CheckStatus", "CheckStatus");
//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");
//                bcp.ColumnMappings.Add("UnderTimeAdjustment", "UnderTimeAdjustment");
//                bcp.ColumnMappings.Add("OverTimeAdjustment", "OverTimeAdjustment");

//                bcp.ColumnMappings.Add("StoreLocation", "StoreLocation");
//                bcp.ColumnMappings.Add("ScheduleUploadDate", "ScheduleUploadDate");
//                bcp.ColumnMappings.Add("AttendanceUploadDate", "AttendanceUploadDate");
//                bcp.ColumnMappings.Add("HRApprove", "HRApprove");

//                bcp.ColumnMappings.Add("HRRemarks", "HRRemarks");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    //dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {


//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Import Attendance Line



//        #region Import Employee Transaction
//        /// <summary>
//        ///Import Employee Transaction
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportEmployeeTransaction()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();

//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);


//                bcp.DestinationTableName = "EmpTransactions";

//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("Phone1", "Phone1");
//                bcp.ColumnMappings.Add("Phone(HomeCountry)", "Phone(HomeCountry)");
//                bcp.ColumnMappings.Add("Email1", "Email1");
//                bcp.ColumnMappings.Add("WorkLocation", "WorkLocation");

//                bcp.ColumnMappings.Add("PassportNo", "PassportNo");
//                bcp.ColumnMappings.Add("PassportValidFrom", "PassportValidFrom");
//                bcp.ColumnMappings.Add("PassportValidTill", "PassportValidTill");
//                bcp.ColumnMappings.Add("VisaNo", "VisaNo");

//                bcp.ColumnMappings.Add("VisaType", "VisaType");
//                bcp.ColumnMappings.Add("VisaValidFrom", "VisaValidFrom");
//                bcp.ColumnMappings.Add("VisaValidTill", "VisaValidTill");
//                bcp.ColumnMappings.Add("IDNo", "IDNo");

//                bcp.ColumnMappings.Add("IDValidFrom", "IDValidFrom");
//                bcp.ColumnMappings.Add("IDValidTill", "IDValidTill");
//                bcp.ColumnMappings.Add("SocialSecurityNo", "SocialSecurityNo");
//                bcp.ColumnMappings.Add("BankName", "BankName");

//                bcp.ColumnMappings.Add("BankBranch", "BankBranch");
//                bcp.ColumnMappings.Add("BankAccountNo", "BankAccountNo");
//                bcp.ColumnMappings.Add("IBANNo", "IBANNo");
//                bcp.ColumnMappings.Add("PersonalCode(VISA)", "PersonalCode(VISA)");

//                bcp.ColumnMappings.Add("BankCode", "BankCode");
//                bcp.ColumnMappings.Add("Designation", "Designation");
//                bcp.ColumnMappings.Add("AirportName", "AirportName");
//                bcp.ColumnMappings.Add("DestinationCity", "DestinationCity");

//                bcp.ColumnMappings.Add("EmployerId", "EmployerId");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Import Employee Transaction



//        #region GetAttendanceDetails
//        /// <summary>
//        ///  Get Attendance Details
//        /// </summary>
//        /// <returns>Datatable Containing Attendance Details</returns>
//        public DataTable GetAttendanceDetails()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAttendanceInfo", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@PunchingTime", SqlDbType.DateTime)).Value = PunchingTime;

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAttendanceDetails

//        #region GetEmpSalaryById
//        /// <summary>
//        ///  Get Emp Salary By Id
//        /// </summary>
//        /// <returns>Datatable Containing Emp Salary By Id</returns>
//        public DataTable GetEmpSalaryById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpSalaryById", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetEmpSalaryById

//        #region Get Salary Head By Id
//        /// <summary>
//        ///   Get Salary Head By Id
//        /// </summary>
//        /// <returns>Datatable Containing Salary Head By Id</returns>
//        public DataTable GetSalaryHeadById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetSalaryHeadById", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@HeadId", SqlDbType.VarChar)).Value = SalaryHeadId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Salary Head By Id



//        #region Insert Shift Master
//        /// <summary>
//        /// Insert Shift Master
//        /// </summary>
//        public bool InsertShiftMaster()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertShiftMaster", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@BreakShift", SqlDbType.Bit)).Value = IsBreakShift;
//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftHeaderId", SqlDbType.VarChar)).Value = ShiftHeaderId;

//                cmdHrms.CommandTimeout = 0;
//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;

//        }
//        #endregion Insert Shift Master

//        #region Insert Shift Transaction
//        /// <summary>
//        /// Insert Shift Transaction
//        /// </summary>
//        public bool InsertShiftTransaction()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertShiftTransaction", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftId", SqlDbType.VarChar)).Value = ShiftId;
//                cmdHrms.Parameters.Add(new SqlParameter("@HeaderId", SqlDbType.VarChar)).Value = ShiftHeaderId;
//                cmdHrms.Parameters.Add(new SqlParameter("@StartTime", SqlDbType.Time)).Value = StartTime;
//                cmdHrms.Parameters.Add(new SqlParameter("@EndTime", SqlDbType.Time)).Value = EndTime;

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkingHours", SqlDbType.Int)).Value = WorkingHours;
//                cmdHrms.Parameters.Add(new SqlParameter("@IsMidnightShift", SqlDbType.Bit)).Value = IsMidnightShift;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;

//        }
//        #endregion Insert Shift Transaction


//        #region Get Shift Master By Id
//        /// <summary>
//        ///   Get Shift Master By Id
//        /// </summary>
//        /// <returns>Datatable Containing Shift Master </returns>
//        public DataTable GetShiftMasterById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetShiftMasterById", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftHeaderId", SqlDbType.VarChar)).Value = ShiftHeaderId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Shift Master By Id

//        #region Get Shift Transaction By Id
//        /// <summary>
//        ///   Get Shift Transaction By Id
//        /// </summary>
//        /// <returns>Datatable Containing Shift Transaction </returns>
//        public DataTable GetShiftTransactionById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetShiftTransactionById", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftHeaderId", SqlDbType.VarChar)).Value = ShiftHeaderId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Shift Transaction By Id

//        #region Get Shift Master
//        /// <summary>
//        ///   Get Shift Master 
//        /// </summary>
//        /// <returns>Datatable Containing Shift Master </returns>
//        public DataTable GetShiftMaster()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetShiftMaster", cnHrms);

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Shift Master

//        #region Update Shift Transaction
//        /// <summary>
//        /// Update Shift Transaction
//        /// </summary>
//        public bool UpdateShiftTransaction()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("UpdateShiftTransaction", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftId", SqlDbType.VarChar)).Value = ShiftId;
//                cmdHrms.Parameters.Add(new SqlParameter("@StartTime", SqlDbType.Time)).Value = StartTime;
//                cmdHrms.Parameters.Add(new SqlParameter("@EndTime", SqlDbType.Time)).Value = EndTime;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkingHours", SqlDbType.Int)).Value = WorkingHours;

//                cmdHrms.Parameters.Add(new SqlParameter("@IsMidnightShift", SqlDbType.Int)).Value = IsMidnightShift;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;

//        }
//        #endregion Update Shift Transaction

//        #region ImportEmployeeShedule
//        /// <summary>
//        ///Import Employee Shedule
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool ImportEmployeeShedule()
//        {
//            bool Result = false;
//            try
//            {
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //            ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "EmployeeShedule";

//                bcp.ColumnMappings.Add("EmpId", "EmpId");
//                bcp.ColumnMappings.Add("ShiftId", "ShiftId");
//                bcp.ColumnMappings.Add("Date", "Date");
//                bcp.ColumnMappings.Add("CreatedDate", "CreatedDate");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion ImportEmployeeShedule

//        #region Get Employee Schedule
//        /// <summary>
//        ///   Get Employee Schedule
//        /// </summary>
//        /// <returns>Datatable Containing Employee Schedule </returns>
//        public DataTable GetEmployeeSchedule()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmployeeShedule", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@ShiftId", SqlDbType.VarChar)).Value = ShiftId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime)).Value = Date;


//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Employee Schedule

//        #region GetShiftDetails
//        /// <summary>
//        /// Get Shift Details
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetShiftDetails()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetShiftDetails", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime)).Value = Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@PunchingTime", SqlDbType.DateTime)).Value = PunchingTime;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetShiftDetails

//        #region GetMidnightShiftDetails
//        /// <summary>
//        /// Get Midnight Shift Details
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetMidnightShiftDetails()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetMidnightShiftDetails", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime)).Value = Date;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetMidnightShiftDetails

//        #region GetCheckInAndCheckOut
//        /// <summary>
//        /// Get Check In And Check Out
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetCheckInAndCheckOut()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetCheckInAndCheckOut", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Type", SqlDbType.Bit)).Value = Type;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromTime", SqlDbType.DateTime)).Value = FromTime;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToTime", SqlDbType.DateTime)).Value = ToTime;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetCheckInAndCheckOut

//        #region GetAttendanceReport
//        /// <summary>
//        /// Get Attendance Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAttendanceReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("Cur_GetAttendanceReportInRange", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromTime.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToTime.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@Type", SqlDbType.Bit)).Value = Type;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAttendanceReport


//        #region GetOverTimeReport
//        /// <summary>
//        /// Get Over Time Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetOverTimeReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                //SqlCommand cmdHrms = new SqlCommand("GetOTSummeryReport", cnHrms);
//                SqlCommand cmdHrms = new SqlCommand("GetOTSummeryReportV2", cnHrms);

//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                // cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear1", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear2", SqlDbType.VarChar)).Value = MonthYear1;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear3", SqlDbType.VarChar)).Value = MonthYear2;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear4", SqlDbType.VarChar)).Value = MonthYear3;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetOverTimeReport

//        #region GetOverTimeReportV1
//        /// <summary>
//        /// Get Over Time Report V1
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetOverTimeReportV1()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetOTSummeryReportV1", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;
//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetOverTimeReportV1


//        #region Insert Attendance Report Header
//        /// <summary>
//        ///Insert Attendance Report Header
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertAttendanceReportHeader()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("InsertAttendanceReportHeader", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate;

//                cmdHrms.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit)).Value = Status;
//                cmdHrms.Parameters.Add(new SqlParameter("@StoreLocation", SqlDbType.VarChar)).Value = StoreLocation;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Insert Attendance Report Header

//        #region Insert Attendance Report Line
//        /// <summary>
//        ///Insert Attendance Report Line
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertAttendanceReportLine()
//        {
//            bool Result = false;
//            try
//            {
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);//add connectionstring here


//                bcp.DestinationTableName = "AttendanceReportLine";//give destination table name

//                bcp.ColumnMappings.Add("column0", "Date");
//                bcp.ColumnMappings.Add("column1", "EmpId");
//                bcp.ColumnMappings.Add("column2", "ShiftId");
//                bcp.ColumnMappings.Add("column3", "EmpName");

//                bcp.ColumnMappings.Add("column4", "CheckIn");
//                bcp.ColumnMappings.Add("column5", "CheckOut");

//                bcp.ColumnMappings.Add("column6", "BreakOut");
//                bcp.ColumnMappings.Add("column7", "BreakIn");
//                bcp.ColumnMappings.Add("column8", "BreakTime");


//                bcp.ColumnMappings.Add("column9", "SchIn");
//                bcp.ColumnMappings.Add("column10", "SchOut");


//                //bcp.ColumnMappings.Add("column5", "WorkedTime");
//                bcp.ColumnMappings.Add("column11", "UnderTime");
//                bcp.ColumnMappings.Add("column12", "OverTime");

//                bcp.ColumnMappings.Add("column13", "Remarks");
//                bcp.ColumnMappings.Add("column14", "CheckStatus");
//                bcp.ColumnMappings.Add("column15", "AttendanceUploadDate");
//                bcp.ColumnMappings.Add("column16", "ScheduleUploadDate");

//                bcp.ColumnMappings.Add("column17", "OverTimeAdjustment");
//                bcp.ColumnMappings.Add("column18", "UnderTimeAdjustment");

//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");
//                bcp.ColumnMappings.Add("StoreLocation", "StoreLocation");

//                //bcp.ColumnMappings.Add("IsEnable", 1);

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Insert Attendance Report Line

//        #region GetSalaryReport
//        /// <summary>
//        /// Get Salary Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetSalaryReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetSalaryReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetSalaryReport



//        #region GetAttendanceReportHeader
//        /// <summary>
//        /// Get Attendance Report Header
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAttendanceReportHeader()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAttendanceReportHeader", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAttendanceReportHeader

//        #region Insert EmpPay Roll
//        /// <summary>
//        ///Insert EmpPay Roll
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertEmpPayRoll()
//        {
//            bool Result = false;
//            try
//            {
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                string dbCntStr = dbHrms.dbCntStr;


//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);//add connectionstring here


//                bcp.DestinationTableName = "EmpPayroll";//give destination table name


//                bcp.ColumnMappings.Add("column2", "EmpId");
//                bcp.ColumnMappings.Add("column3", "EmpName");
//                bcp.ColumnMappings.Add("column4", "PresentDays");
//                bcp.ColumnMappings.Add("column5", "Basic");
//                bcp.ColumnMappings.Add("column6", "HRA");

//                bcp.ColumnMappings.Add("column7", "TRA");
//                bcp.ColumnMappings.Add("column8", "MBA");
//                bcp.ColumnMappings.Add("column9", "Others");
//                bcp.ColumnMappings.Add("column10", "EarningsTotal");

//                bcp.ColumnMappings.Add("column11", "Deductions");
//                bcp.ColumnMappings.Add("column12", "NetSalary");
//                bcp.ColumnMappings.Add("column13", "Level1CheckStatus");
//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");

//                bcp.ColumnMappings.Add("Level1CheckDoneBy", "Level1CheckDoneBy");
//                bcp.ColumnMappings.Add("Level1CheckDate", "Level1CheckDate");

//                //bcp.ColumnMappings.Add("IsEnable", 1);

//                // and so on...., maap all source table with your destination table

//                DtSource.Columns.Remove("column0");
//                DtSource.Columns.Remove("column1");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Insert EmpPay Roll

//        #region Get Emp Payroll
//        /// <summary>
//        /// Get Emp Payroll
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmpPayroll()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpPayroll", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToEmpId", SqlDbType.VarChar)).Value = ToEmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Emp Payroll

//        #region Get Emp Payroll By Id
//        /// <summary>
//        /// Get Emp Payroll By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmpPayrollById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpPayrollById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Emp Payroll By Id

//        #region GetSalaryReportInRange
//        /// <summary>
//        /// GetSalaryReportInRange
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetSalaryReportInRange()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                string Country = Common.Location;
//                SqlCommand cmdHrms = null;
//                switch (Country)
//                {
//                    case "Qatar":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_Qatar", cnHrms);
//                        break;
//                    case "Oman":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_Oman", cnHrms);
//                        break;
//                    case "UAE":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_UAE", cnHrms);
//                        break;
//                    case "Jordan":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_Jordan", cnHrms);
//                        break;
//                    case "Bahrain":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_Bahrain", cnHrms);
//                        break;
//                    case "KSA":
//                        cmdHrms = new SqlCommand("Cur_GetSalaryReportInRange_KSA", cnHrms);
//                        break;
//                }
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@ProcessDate", SqlDbType.DateTime)).Value = Date;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetSalaryReportInRange

//        #region Insert Vacation Info
//        /// <summary>
//        ///Insert Vaction Info
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertVacationInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("InsertVacationInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@EligibleDays", SqlDbType.Int)).Value = EligibleDays;
//                cmdHrms.Parameters.Add(new SqlParameter("@DuePeriod", SqlDbType.VarChar)).Value = DuePeriod;
//                cmdHrms.Parameters.Add(new SqlParameter("@TicketDuePeriod", SqlDbType.Int)).Value = TicketDuePeriod;

//                cmdHrms.Parameters.Add(new SqlParameter("@StartingDate", SqlDbType.DateTime)).Value = StartingDate;
//                cmdHrms.Parameters.Add(new SqlParameter("@IsEnable", SqlDbType.Int)).Value = IsEnable;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion Insert Vacation Info

//        #region Update Vacation Info
//        /// <summary>
//        ///Update Vacation Info
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateVacationInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("UpdateVacationInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@EligibleDays", SqlDbType.Int)).Value = EligibleDays;
//                cmdHrms.Parameters.Add(new SqlParameter("@DuePeriod", SqlDbType.VarChar)).Value = DuePeriod;
//                cmdHrms.Parameters.Add(new SqlParameter("@TicketDuePeriod", SqlDbType.VarChar)).Value = TicketDuePeriod;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion Update Vacation Info

//        #region Get Vacation Info By Id
//        /// <summary>
//        /// Get Vacation Info By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetVacationInfoById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetVacationInfoById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Vacation Info By Id

//        #region GetVacationAccrualHistory
//        /// <summary>
//        /// Get Vacation Accrual History
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetVacationAccrualHistory()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetVacationAccrualHistory", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                // cmdHrms.Parameters.Add(new SqlParameter("@FromEmpId", SqlDbType.VarChar)).Value = EmpId;
//                // cmdHrms.Parameters.Add(new SqlParameter("@ToEmpId", SqlDbType.VarChar)).Value = ToEmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@dtDate", SqlDbType.DateTime)).Value = Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetVacationAccrualHistory

//        #region Insert Vacation Accrual
//        /// <summary>
//        ///Insert Vacation Accrual
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertVacationAccrual()
//        {
//            bool Result = false;
//            try
//            {
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                string dbCntStr = dbHrms.dbCntStr;


//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);//add connectionstring here


//                bcp.DestinationTableName = "VacationAccrualHistory";//give destination table name


//                bcp.ColumnMappings.Add("column0", "EmpId");
//                bcp.ColumnMappings.Add("column1", "DateOfJoining");
//                bcp.ColumnMappings.Add("column2", "NoOfDaysWorked");
//                bcp.ColumnMappings.Add("column3", "EligibleDays");

//                bcp.ColumnMappings.Add("column4", "DuePeriod");
//                bcp.ColumnMappings.Add("column5", "AccrualBasisAmount");
//                bcp.ColumnMappings.Add("column6", "OpeningBalanceDays");
//                bcp.ColumnMappings.Add("column7", "OpeningBalanceAmount");

//                bcp.ColumnMappings.Add("column8", "AccruedDays");
//                bcp.ColumnMappings.Add("column9", "AccruedAmount");
//                bcp.ColumnMappings.Add("column10", "AvailedDays");
//                bcp.ColumnMappings.Add("column11", "AvailedAmount");

//                bcp.ColumnMappings.Add("column12", "AdjustedDays");
//                bcp.ColumnMappings.Add("column13", "AdjustedAmount");
//                bcp.ColumnMappings.Add("column14", "ClosingBalanceDays");
//                bcp.ColumnMappings.Add("column15", "ClosingBalanceAmount");

//                bcp.ColumnMappings.Add("column16", "Level1CheckStatus");
//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");
//                bcp.ColumnMappings.Add("Level1CheckDoneBy", "Level1CheckDoneBy");
//                bcp.ColumnMappings.Add("Level1CheckDate", "Level1CheckDate");

//                //bcp.ColumnMappings.Add("IsEnable", 1);
//                // and so on...., maap all source table with your destination table

//                // DtSource.Columns.Remove("column0");
//                // DtSource.Columns.Remove("column1");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion Insert Vacation Accrual

//        #region Get Vacation Accrual By Id
//        /// <summary>
//        /// Get Vacation Accrual By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetVacationAccrualById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetVacationAccrualHistoryById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Vacation Accrual By Id


//        #region GetIndemnityAccrualHistory
//        /// <summary>
//        /// Get Indemnity Accrual History
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetIndemnityAccrualHistory()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetIndemnityAccrualHistory", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //cmdHrms.Parameters.Add(new SqlParameter("@FromEmpId", SqlDbType.VarChar)).Value = EmpId;
//                //cmdHrms.Parameters.Add(new SqlParameter("@ToEmpId", SqlDbType.VarChar)).Value = ToEmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@dtDate", SqlDbType.DateTime)).Value = Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetIndemnityAccrualHistory

//        #region InsertIndemnityAccrual
//        /// <summary>
//        ///Insert Indemnity Accrual
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertIndemnityAccrual()
//        {
//            bool Result = false;
//            try
//            {
//                //string dbCntStr = (null != ConfigurationManager.ConnectionStrings["HrmsConnectionString"])
//                //        ? ConfigurationManager.ConnectionStrings["HrmsConnectionString"].ConnectionString : "";

//                DatabaseConnection dbHrms = new DatabaseConnection();
//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);//add connectionstring here


//                bcp.DestinationTableName = "IndemnityAccrualHistory";//give destination table name


//                bcp.ColumnMappings.Add("column0", "EmpId");
//                bcp.ColumnMappings.Add("column1", "DateOfJoining");
//                bcp.ColumnMappings.Add("column2", "NoOfWorkingDays");
//                bcp.ColumnMappings.Add("column3", "AccrualBasisAmount");

//                bcp.ColumnMappings.Add("column4", "OpeningBalance");
//                bcp.ColumnMappings.Add("column5", "AccrualForTheMonth");
//                bcp.ColumnMappings.Add("column6", "Availments");
//                bcp.ColumnMappings.Add("column7", "Adjustments");

//                bcp.ColumnMappings.Add("column8", "ClosingBalance");
//                bcp.ColumnMappings.Add("column9", "GratuityDays");
//                bcp.ColumnMappings.Add("column10", "Level1CheckStatus");

//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");
//                bcp.ColumnMappings.Add("Level1CheckDoneBy", "Level1CheckDoneBy");
//                bcp.ColumnMappings.Add("Level1CheckDate", "Level1CheckDate");


//                //bcp.ColumnMappings.Add("IsEnable", 1);
//                // and so on...., maap all source table with your destination table

//                // DtSource.Columns.Remove("column0");
//                // DtSource.Columns.Remove("column1");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }

//            return Result;

//        }
//        #endregion InsertIndemnityAccrual

//        #region Get Indemnity Accrual By Id
//        /// <summary>
//        /// Get Indemnity Accrual By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetIndemnityAccrualById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetIndemnityAccrualHistoryById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Indemnity Accrual By Id


//        #region GetOTData
//        /// <summary>
//        /// Get OT Data for OT Management
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetOTData()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetOTData", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //DateTime dFromTime = FromTime.Date;
//                //DateTime dToTime = ToTime.Date;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                //cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = StoreLocation;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);

//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetOTData

//        #region UpdateAttendaceReportLine
//        /// <summary>
//        /// Update Attendace Report Line
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool UpdateAttendaceReportLine()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(Id int,EmpId varchar(10),OverTimeAdjustment int,UnderTimeAdjustment int)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 500;
//                        command.CommandText = "UPDATE T SET OverTimeAdjustment=Temp.OverTimeAdjustment,UnderTimeAdjustment=Temp.UnderTimeAdjustment  FROM AttendanceReportLine  T INNER JOIN #TmpTable Temp ON  T.EmpId=Temp.EmpId and T.Id=Temp.Id; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion UpdateAttendaceReportLine

//        #region GetNationalityMix
//        /// <summary>
//        /// Get Nationality Mix
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetNationalityMix()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetNationalityMix", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                //cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = StoreLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetNationalityMix

//        #region Get Age Mix
//        /// <summary>
//        /// Get Age Mix
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAgeMix()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAgeMix", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                // cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = StoreLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  Get Age Mix

//        #region Get Visa Renewal Report
//        /// <summary>
//        ///Get Visa Renewal Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetVisaRenewalReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetVisaRenewalReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.Parameters.Add(new SqlParameter("@AsOfDate", SqlDbType.DateTime)).Value = AsOfDate;
//                //cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value =StoreLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  Get Visa Renewal Report

//        #region Insert Air Fare
//        /// <summary>
//        ///Insert Air Fare
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertAirFare()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("InsertEmpAirfare", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@PaidAmount", SqlDbType.Decimal)).Value = PaidAmount;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@PaidDate", SqlDbType.DateTime)).Value = PaidDate;

//                cmdHrms.Parameters.Add(new SqlParameter("@DoneBy", SqlDbType.VarChar)).Value = Common.EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }


//        #endregion Insert Air Fare

//        #region GetEmpAirfare
//        /// <summary>
//        /// Get Emp Airfare
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmpAirfare()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpAirfare", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetEmpAirfare

//        #region Insert Emp Transaction Details
//        /// <summary>
//        ///Insert Emp Transaction Details
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertEmpTransactionDetails()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("InsertEmpTransactions", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Phone1", SqlDbType.NVarChar)).Value = Phone1;
//                cmdHrms.Parameters.Add(new SqlParameter("@PhoneHomeCountry", SqlDbType.NVarChar)).Value = PhoneHomeCountry;
//                cmdHrms.Parameters.Add(new SqlParameter("@Email1", SqlDbType.NVarChar)).Value = Email;

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.NVarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@Designation", SqlDbType.NVarChar)).Value = Designation;
//                cmdHrms.Parameters.Add(new SqlParameter("@PassportNo", SqlDbType.NVarChar)).Value = PassportNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidFrom", SqlDbType.DateTime)).Value = PassportValidFrom;

//                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidTill", SqlDbType.DateTime)).Value = PassportValidTill;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaNo", SqlDbType.NVarChar)).Value = VisaNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaType", SqlDbType.NVarChar)).Value = VisaType;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidFrom", SqlDbType.DateTime)).Value = VisaValidFrom;

//                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidTill", SqlDbType.DateTime)).Value = VisaValidTill;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDNo", SqlDbType.NVarChar)).Value = IDNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDValidFrom", SqlDbType.DateTime)).Value = IDValidFrom;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDValidTill", SqlDbType.DateTime)).Value = IDValidTill;

//                cmdHrms.Parameters.Add(new SqlParameter("@SocialSecurityNo", SqlDbType.NVarChar)).Value = SocialSecurityNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankName", SqlDbType.NVarChar)).Value = BankName;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankBranch", SqlDbType.NVarChar)).Value = BankBranch;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankAccountNo", SqlDbType.NVarChar)).Value = BankAccountNo;

//                cmdHrms.Parameters.Add(new SqlParameter("@IBANNo", SqlDbType.NVarChar)).Value = IBANNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;
//                cmdHrms.Parameters.Add(new SqlParameter("@PersonalCodeVISA", SqlDbType.NVarChar)).Value = PersonalCodeVISA;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.NVarChar)).Value = BankCode;

//                cmdHrms.Parameters.Add(new SqlParameter("@AirportName", SqlDbType.NVarChar)).Value = AirportName;
//                cmdHrms.Parameters.Add(new SqlParameter("@DestinationCity", SqlDbType.NVarChar)).Value = DestinationCity;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;

//                cmdHrms.Parameters.Add(new SqlParameter("@GosiAmount", SqlDbType.Decimal)).Value = GosiAmount;
//                cmdHrms.Parameters.Add(new SqlParameter("@IsLocal", SqlDbType.Bit)).Value = IsLocal;


//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Insert Emp Transaction Details

//        #region Update Emp Transaction Details
//        /// <summary>
//        ///Update Emp Transaction Details
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateEmpTransactionDetails()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("UpdateEmpTransaction", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Phone1", SqlDbType.NVarChar)).Value = Phone1;
//                cmdHrms.Parameters.Add(new SqlParameter("@PhoneHomeCountry", SqlDbType.NVarChar)).Value = PhoneHomeCountry;
//                cmdHrms.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = Email;

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.NVarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@Designation", SqlDbType.NVarChar)).Value = Designation;
//                cmdHrms.Parameters.Add(new SqlParameter("@PassportNo", SqlDbType.NVarChar)).Value = PassportNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidFrom", SqlDbType.DateTime)).Value = PassportValidFrom;

//                cmdHrms.Parameters.Add(new SqlParameter("@PassportValidTill", SqlDbType.DateTime)).Value = PassportValidTill;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaNo", SqlDbType.NVarChar)).Value = VisaNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaType", SqlDbType.NVarChar)).Value = VisaType;
//                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidFrom", SqlDbType.DateTime)).Value = VisaValidFrom;

//                cmdHrms.Parameters.Add(new SqlParameter("@VisaValidTill", SqlDbType.DateTime)).Value = VisaValidTill;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDNo", SqlDbType.NVarChar)).Value = IDNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDValidFrom", SqlDbType.DateTime)).Value = IDValidFrom;
//                cmdHrms.Parameters.Add(new SqlParameter("@IDValidTill", SqlDbType.DateTime)).Value = IDValidTill;

//                cmdHrms.Parameters.Add(new SqlParameter("@SocialSecurityNo", SqlDbType.NVarChar)).Value = SocialSecurityNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankName", SqlDbType.NVarChar)).Value = BankName;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankBranch", SqlDbType.NVarChar)).Value = BankBranch;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankAccountNo", SqlDbType.NVarChar)).Value = BankAccountNo;

//                cmdHrms.Parameters.Add(new SqlParameter("@IBANNo", SqlDbType.NVarChar)).Value = IBANNo;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;
//                cmdHrms.Parameters.Add(new SqlParameter("@PersonalCodeVISA", SqlDbType.NVarChar)).Value = PersonalCodeVISA;
//                cmdHrms.Parameters.Add(new SqlParameter("@BankCode", SqlDbType.NVarChar)).Value = BankCode;

//                cmdHrms.Parameters.Add(new SqlParameter("@AirportName", SqlDbType.NVarChar)).Value = AirportName;
//                cmdHrms.Parameters.Add(new SqlParameter("@DestinationCity", SqlDbType.NVarChar)).Value = DestinationCity;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.Parameters.Add(new SqlParameter("@GosiAmount", SqlDbType.Decimal)).Value = GosiAmount;

//                cmdHrms.Parameters.Add(new SqlParameter("@IsLocal", SqlDbType.Bit)).Value = IsLocal;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Update Emp Transaction Details

//        #region Get All EmpInfo ById
//        /// <summary>
//        /// Get All EmpInfo ById
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAllEmpInfoById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAllEmpInfoById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  Get All EmpInfo ById

//        #region Get Attendance Report Line
//        /// <summary>
//        /// Get Attendance Report Line
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAttendanceReportLine()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAttendanceReportLine", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Type", SqlDbType.Bit)).Value = Type;
//                //cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate.Date;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  GetAttendanceReportLine


//        #region UpdateHRAttendaceReportLine
//        /// <summary>
//        /// Update HR Attendace ReportLine
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool UpdateHRAttendaceReportLine()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(EmpId varchar(10),HRRemarks varchar(MAX),HRApprove bit,Id int,)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 500;
//                        command.CommandText = "UPDATE T SET HRRemarks=Temp.HRRemarks,HRApprove=Temp.HRApprove  FROM AttendanceReportLine  T INNER JOIN #TmpTable Temp ON  T.EmpId=Temp.EmpId COLLATE DATABASE_DEFAULT and T.Id=Temp.Id; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion UpdateHRAttendaceReportLine


//        #region GetTicketAccrualInRange
//        /// <summary>
//        /// Get Ticket Accrual InRange
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetTicketAccrualInRange()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("Cur_GetTicketAccrualInRange", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Location", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@CurrentDate", SqlDbType.DateTime)).Value = Date;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  GetTicketAccrualInRange


//        #region Insert Ticket Accrual
//        /// <summary>
//        ///Insert Ticket Accrual
//        /// </summary>
//        /// <param name="dtSource"></param>
//        public bool InsertTicketAccrual()
//        {
//            bool Result = false;
//            try
//            {
//                DatabaseConnection dbHrms = new DatabaseConnection();

//                string dbCntStr = dbHrms.dbCntStr;

//                System.Data.SqlClient.SqlBulkCopy bcp = new System.Data.SqlClient.SqlBulkCopy(dbCntStr);

//                bcp.DestinationTableName = "TicketAccrualHistory";

//                bcp.ColumnMappings.Add("Column0", "EmpId");
//                bcp.ColumnMappings.Add("Column1", "EmpName");
//                bcp.ColumnMappings.Add("Column2", "DateOfJoining");
//                bcp.ColumnMappings.Add("Column3", "TicketAmount");

//                bcp.ColumnMappings.Add("Column4", "Days");
//                bcp.ColumnMappings.Add("Column5", "Opening");
//                bcp.ColumnMappings.Add("Column6", "Accrued");
//                bcp.ColumnMappings.Add("Column7", "Adjustment");

//                bcp.ColumnMappings.Add("Column8", "Availed");
//                bcp.ColumnMappings.Add("Column9", "Closing");
//                bcp.ColumnMappings.Add("Column10", "Approve");

//                bcp.ColumnMappings.Add("MonthYear", "MonthYear");
//                bcp.ColumnMappings.Add("CheckDoneBy", "CheckDoneBy");
//                bcp.ColumnMappings.Add("CheckDate", "CheckDate");
//                bcp.ColumnMappings.Add("StoreLocation", "StoreLocation");

//                if (DtSource.Rows.Count > 0)
//                {
//                    bcp.WriteToServer(DtSource);
//                    Result = true;
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            catch (SqlException ex)
//            {
//                ExceptionMessage = ex.Message;
//            }
//            return Result;
//        }
//        #endregion Insert Ticket Accrual

//        #region GetPassportRenewalReport
//        /// <summary>
//        /// Get Passport Renewal Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetPassportRenewalReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetPassportRenewalReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion  GetPassportRenewalReport


//        #region Get Employer Info
//        /// <summary>
//        /// Get Employer Info
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmployerInfo()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmployerInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Employer Info


//        #region Get Employer Info By Id
//        /// <summary>
//        /// Get Employer Info By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmployerInfoById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmployerInfoById", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Employer Info By Id


//        #region Get Ticket Accrual By Store
//        /// <summary>
//        /// Get Ticket Accrual By Store
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetTicketAccrualByStore()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetTicketAccrualByStore", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@StoreLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Ticket Accrual By Store

//        #region Get WPS Data
//        /// <summary>
//        /// Get WPS Data
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetWPSData()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("Cur_GetWpsData", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@CurrentDate", SqlDbType.DateTime)).Value = Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get WPS Data


//        #region GetEmpPayrollByVisaGroup
//        /// <summary>
//        /// GetEmpPayrollByVisaGroup
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmpPayrollByVisaGroup()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpPayrollByVisaGroup", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetEmpPayrollByVisaGroup


//        #region UpdateEmpSalary
//        /// <summary>
//        /// Update Update Emp Salary
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool UpdateEmpSalary()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(SalaryHeadId int,EmpId varchar(20),Amount decimal(18,10),CreatedDate DateTime,Id int)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 500;
//                        command.CommandText = "UPDATE T SET SalaryHeadId=Temp.SalaryHeadId,Amount=Temp.Amount,CreatedDate=Temp.CreatedDate FROM EmpSalary T INNER JOIN #TmpTable Temp ON  T.EmpId=Temp.EmpId and T.id=Temp.Id; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion UpdateEmpSalary


//        #region GetStoreDetails
//        /// <summary>
//        /// GetStoreDetails
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetStoreDetails()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetStoreDetails", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetStoreDetails


//        #region ExportAttendanceLineInRange
//        /// <summary>
//        /// Export Attendance Line InRange
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportAttendanceLineInRange()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportAttendanceLineInRange", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion ExportAttendanceLineInRange


//        #region GetAllEmpInfoByStore
//        /// <summary>
//        /// GetAllEmpInfoByStore
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAllEmpInfoByStore()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAllEmpInfoByStore", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAllEmpInfoByStore

//        #region Delete Attendance Report
//        /// <summary>
//        /// Delete Attendance Report
//        /// </summary>
//        /// <returns></returns>
//        public bool DeleteAttendanceReport()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("DeleteAttendanceReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@empId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@fromDate", SqlDbType.DateTime)).Value = FromDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@toDate", SqlDbType.DateTime)).Value = ToDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@type", SqlDbType.Bit)).Value = Type;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion DeleteAttendanceReport


//        #region GetAttendanceCount
//        /// <summary>
//        /// GetAttendanceCount
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAttendanceCount()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAttendanceCount", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAttendanceCount


//        #region ExportSalaryReport
//        /// <summary>
//        /// ExportSalaryReport
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportSalaryReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportSalaryReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@workLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@monthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion ExportSalaryReport

//        #region ExportGeneralSalaryReport
//        /// <summary>
//        /// ExportGeneralSalaryReport
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportGeneralSalaryReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportGeneralSalaryReport", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@workLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@monthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@lastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;

//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion ExportGeneralSalaryReport

//        #region Change Password
//        /// <summary>
//        /// Change Password
//        /// </summary>
//        /// <returns></returns>
//        public bool ChangePassword()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;


//                SqlCommand cmdHrms = new SqlCommand("ChangePassword", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@empId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@currentPassword", SqlDbType.VarChar)).Value = CurrentPassword;
//                cmdHrms.Parameters.Add(new SqlParameter("@newPassword", SqlDbType.VarChar)).Value = NewPassword;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion ChangePassword


//        #region Get Remarks
//        /// <summary>
//        /// Get Remarks
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetRemarks()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetRemarks", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Remarks

//        #region Get Server Date
//        /// <summary>
//        /// Get Server Date
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetServerDate()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetServerDate", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Server Date

//        #region Get Cut Off Dates
//        /// <summary>
//        /// Get Cut Off Dates
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetCutOffDates()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetCutOffDates", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get CutOff Dates

//        #region Insert Salary Transactions
//        /// <summary>
//        ///Insert Salary Transactions
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertSalaryTransactions()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("InsertSalaryTransaction", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryHead", SqlDbType.VarChar)).Value = SalaryHead;
//                cmdHrms.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal)).Value = SalaryAmount;
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryReasonCode", SqlDbType.VarChar)).Value = SalaryReasonCode;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = DateTime.Now;

//                cmdHrms.Parameters.Add(new SqlParameter("@DoneBy", SqlDbType.VarChar)).Value = Common.EmpId;
//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Insert Salary Transactions

//        #region Get Salary Adjustment Reason
//        /// <summary>
//        /// Get Salary Adjustment Reason
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetSalaryAdjustmentReason()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetSalaryAdjustmentReason", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Salary Adjustment Reason

//        #region Get Salary Adjustment Reason By Id
//        /// <summary>
//        /// Get Salary Adjustment Reason By Id
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetSalaryAdjustmentReasonById()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetSalaryAdjustmentReasonById", cnHrms);
//                cmdHrms.Parameters.Add(new SqlParameter("@Code", SqlDbType.VarChar)).Value = SalaryReasonCode;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Salary Adjustment Reason ById

//        #region GetBonusAmount
//        /// <summary>
//        /// GetBonusAmount
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetBonusAmount()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetBonusAmount", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@BonusPercentage", SqlDbType.Int)).Value = BonusPercentage;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetBonusAmount

//        #region UpdateEmpBonus
//        /// <summary>
//        /// UpdateEmpBonus
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool UpdateEmpBonus()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(Id int,Approve bit)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 500;
//                        command.CommandText = "UPDATE T SET Approve=Temp.Approve  FROM EmpBonus T INNER JOIN #TmpTable Temp ON T.Id=Temp.Id; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion UpdateEmpBonus

//        #region UpdateEmpPayroll
//        /// <summary>
//        /// UpdateEmpPayroll
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool UpdateEmpPayroll()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(Id int,Level1CheckStatus bit)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 500;
//                        command.CommandText = "UPDATE T SET Level1CheckStatus=Temp.Level1CheckStatus FROM EmpPayroll T INNER JOIN #TmpTable Temp ON T.Id=Temp.Id; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion UpdateEmpPayroll

//        #region GetWPSDataQatar
//        /// <summary>
//        /// GetWPSDataQatar
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetWPSDataQatar()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetWPSDataQatar", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.VarChar)).Value = Common.EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@LastMonthYear", SqlDbType.VarChar)).Value = LastMonthYear;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetWPSDataQatar

//        #region GetWPSEmployerQatar
//        /// <summary>
//        /// GetWPSEmployerQatar
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetWPSEmployerQatar()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetWPSEmployerQatar", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmployerId", SqlDbType.VarChar)).Value = EmployerId;
//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetWPSEmployerQatar

//        #region Export Bonus Report
//        /// <summary>
//        /// Export Bonus Report
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportBonusReport()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportBonusReport", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@MonthYear", SqlDbType.VarChar)).Value = MonthYear;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Export Bonus Report

//        #region GetDesignation
//        /// <summary>
//        /// Get Designation
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetDesignation()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;
//                SqlCommand cmdHrms = new SqlCommand("GetEmpDesignation", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetDesignation

//        #region Update Attendance Log
//        /// <summary>
//        /// Update Attendance Log
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateAttendanceLog()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ImportAttendance", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;


//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }
//        #endregion Update Attendance Log


//        #region ExportVacationInfo
//        /// <summary>
//        /// ExportVacationInfo
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportVacationInfo()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportVacationInfo", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion ExportVacationInfo

//        #region ExportSalaryInfo
//        /// <summary>
//        /// ExportSalaryInfo
//        /// </summary>
//        /// <returns></returns>
//        public DataTable ExportSalaryInfo()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("ExportSalaryInfo", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion ExportSalaryInfo


//        //Holyday Master  Start

//        #region Insert Holiday Master
//        /// <summary>
//        ///Insert Holiday Master
//        /// </summary>
//        /// <returns></returns>
//        public bool InsertHolidayMaster()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("InsertHolidayMaster", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar)).Value = Description;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedBy", SqlDbType.VarChar)).Value = Common.EmpId;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Insert Holiday Master

//        #region Update Holiday Master
//        /// <summary>
//        ///Update Holiday Master
//        /// </summary>
//        /// <returns></returns>
//        public bool UpdateHolidayMaster()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("UpdateHolidayMaster", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar)).Value = Description;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Update Holiday Master

//        #region Delete Holiday Master
//        /// <summary>
//        ///Delete Holiday Master
//        /// </summary>
//        /// <returns></returns>
//        public bool DeleteHolidayMaster()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("DeleteHolidayMaster", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = Date;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Delete Holiday Master

//        #region GetHolidayMasterByDate
//        /// <summary>
//        /// GetHolidayMasterByDate
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetHolidayMasterByDate()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetHolidayMasterByDate", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime)).Value = Date;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetHolidayMasterByDate

//        //Holyday Master  End


//        //Check Attendance Log Start

//        #region Get AttendanceInfo By EmpId
//        /// <summary>
//        /// Get AttendanceInfo By EmpId
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetAttendanceInfoByEmpId()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetAttendanceInfoByEmpId", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@FromDate", SqlDbType.DateTime)).Value = FromDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@ToDate", SqlDbType.DateTime)).Value = ToDate.Date;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion GetAttendanceInfoByEmpId

//        #region CheckAttendanceLog
//        /// <summary>
//        /// CheckAttendanceLog
//        /// </summary>
//        /// <param name="dtSalaryReport"></param>
//        public bool CheckAttendanceLog()
//        {
//            DatabaseConnection dbHrms = new DatabaseConnection();
//            bool Result = false;
//            using (SqlConnection conn = dbHrms.CnDbConnection)
//            {
//                using (SqlCommand command = new SqlCommand("", conn))
//                {
//                    try
//                    {
//                        //Creating temp table on database
//                        command.CommandText = "CREATE TABLE #TmpTable(AttId int,EmpId varchar(20),IsEnable bit)";
//                        //MonthYear varchar(15)
//                        command.ExecuteNonQuery();

//                        //Bulk insert into temp table
//                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(conn))
//                        {
//                            bulkcopy.BulkCopyTimeout = 660;
//                            bulkcopy.DestinationTableName = "#TmpTable";
//                            bulkcopy.WriteToServer(DtSource);
//                            bulkcopy.Close();
//                        }

//                        // Updating destination table, and dropping temp table
//                        command.CommandTimeout = 0;
//                        command.CommandText = "UPDATE T SET IsEnable=Temp.IsEnable FROM AttendanceInfo T INNER JOIN #TmpTable Temp ON  T.EmpId=Temp.EmpId and T.AttendanceId=Temp.AttId; DROP TABLE #TmpTable;";
//                        Result = (command.ExecuteNonQuery() > 0) ? true : false;

//                    }
//                    catch (Exception ex)
//                    {
//                        // Handle exception properly
//                        // MessageBox.Show("Level2 Checking Failed.");
//                    }
//                    finally
//                    {
//                        dbHrms.CloseDbConnection();
//                    }
//                }
//            }

//            return Result;
//        }
//        #endregion CheckAttendanceLog


//        //Check Attendance Log End

//        #region Delete Emp Salary
//        /// <summary>
//        /// Delete Emp Salary
//        /// </summary>
//        /// <returns></returns>
//        public bool DeleteEmpSalary()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("DeleteEmpSalary", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;

//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;
//                cmdHrms.Parameters.Add(new SqlParameter("@SalaryHeadId", SqlDbType.Int)).Value = SalaryHeadId;
//                cmdHrms.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime)).Value = CreatedDate;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion Delete Emp Salary

//        #region DeleteVacationInfo
//        /// <summary>
//        /// DeleteVacationInfo
//        /// </summary>
//        /// <returns></returns>
//        public bool DeleteVacationInfo()
//        {
//            bool Result = false;

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("DeleteVacationInfo", cnHrms);
//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.VarChar)).Value = EmpId;

//                cmdHrms.CommandTimeout = 0;

//                try
//                {
//                    Result = (cmdHrms.ExecuteNonQuery() > 0) ? true : false;
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }

//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return Result;
//        }

//        #endregion DeleteVacationInfo

//        #region Get Emp Info By Store
//        /// <summary>
//        /// Get Emp Info By Store
//        /// </summary>
//        /// <returns></returns>
//        public DataTable GetEmpInfoByStore()
//        {
//            DataTable dtHrms = new DataTable();

//            DatabaseConnection dbHrms = new DatabaseConnection();

//            if (dbHrms.DbConnectionFailureMessage.Trim().Length <= 0)
//            {
//                SqlConnection cnHrms = dbHrms.CnDbConnection;

//                SqlCommand cmdHrms = new SqlCommand("GetEmpInfoByStore", cnHrms);

//                cmdHrms.Parameters.Add(new SqlParameter("@WorkLocation", SqlDbType.VarChar)).Value = WorkLocation;
//                cmdHrms.Parameters.Add(new SqlParameter("@SchDate", SqlDbType.Date)).Value = ScheduleDate.Date;

//                cmdHrms.CommandType = CommandType.StoredProcedure;
//                cmdHrms.CommandTimeout = 0;

//                SqlDataAdapter daStock = new SqlDataAdapter(cmdHrms);
//                try
//                {
//                    daStock.Fill(dtHrms);
//                    ExceptionMessage = "";
//                }
//                catch (SqlException ex)
//                {
//                    ExceptionMessage = ex.Message;
//                }
//                finally
//                {
//                    dbHrms.CloseDbConnection();
//                }
//            }
//            else
//            {
//                ExceptionMessage = dbHrms.DbConnectionFailureMessage.Trim();
//            }

//            return dtHrms;
//        }
//        #endregion Get Emp Info By Store
//    }
//}