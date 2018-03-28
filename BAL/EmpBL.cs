using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMSWeb.DAL;
using System.Data;

namespace HRMSWeb.BAL
{

    public class EmpBL
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


        #region Methods


        #region InsertEmployeeInfo
        /// <summary>
        /// InsertEmployeeInfo
        /// </summary>
        /// <returns></returns>
        public bool InsertEmployeeInfo()
        {
            EmpDAL objEmp = new EmpDAL();

            objEmp.EmpId = EmpId;
            objEmp.FirstName = FirstName;
            objEmp.MiddleName = MiddleName;
            objEmp.LastName = LastName;

            objEmp.DOB = DOB;
            objEmp.Gender = Gender;
            objEmp.PresentAddress = PresentAddress;
            objEmp.PermanentAddress = PermanentAddress;

            objEmp.JoiningDate = JoiningDate;
            objEmp.MaritalStatus = MaritalStatus;
            objEmp.Nationality = Nationality;
            objEmp.EmpStatus = EmpStatus;

            objEmp.Phone1 = Phone1;
            objEmp.PhoneHomeCountry = PhoneHomeCountry;
            objEmp.Email = Email;
            objEmp.WorkLocation = WorkLocation;

            objEmp.Designation = Designation;
            objEmp.PassportNo = PassportNo;
            objEmp.PassportValidFrom = PassportValidFrom;
            objEmp.PassportValidTill = PassportValidTill;

            objEmp.VisaNo = VisaNo;
            objEmp.VisaType = VisaType;
            objEmp.VisaValidFrom = VisaValidFrom;
            objEmp.VisaValidTill = VisaValidTill;

            objEmp.IDNo = IDNo;
            objEmp.IDValidFrom = IDValidFrom;
            objEmp.IDValidTill = IDValidTill;
            objEmp.SocialSecurityNo = SocialSecurityNo;

            objEmp.BankName = BankName;
            objEmp.BankBranch = BankBranch;
            objEmp.BankAccountNo = BankAccountNo;
            objEmp.IBANNo = IBANNo;

            objEmp.PersonalCodeVISA = PersonalCodeVISA;
            objEmp.BankCode = BankCode;
            objEmp.AirportName = AirportName;
            objEmp.DestinationCity = DestinationCity;

            objEmp.EmployerId = EmployerId;
            objEmp.GosiAmount = GosiAmount;
            objEmp.IsLocal = IsLocal;

            bool Result = objEmp.InsertEmployeeInfo();

            return Result;
        }
        #endregion InsertEmployeeInfo

        #region UpdateEmployeeInfo
        /// <summary>
        /// UpdateEmployeeInfo
        /// </summary>
        /// <returns></returns>
        public bool UpdateEmployeeInfo()
        {
            EmpDAL objEmp = new EmpDAL();

            objEmp.EmpId = EmpId;
            objEmp.StoreLocation = StoreLocation;
            objEmp.EmpStatus = EmpStatus;

            bool Result = objEmp.UpdateEmployeeInfo();

            return Result;
        }
        #endregion UpdateEmployeeInfo

        #region GetAllEmployeeInfo
        /// <summary>
        /// GetAllEmployeeInfo
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllEmployeeInfo()
        {
            EmpDAL objEmp = new EmpDAL();
            DataTable dt=objEmp.GetAllEmployeeInfo();
            return dt;
        }
        #endregion GetAllEmployeeInfo


        #region GetAllEmployeeInfoByEmpId
        /// <summary>
        /// GetAllEmployeeInfoByEmpId
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllEmployeeInfoByEmpId()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.EmpId = EmpId;
            DataTable dt = objEmp.GetAllEmployeeInfoByEmpId();
            return dt;
        }
        #endregion GetAllEmployeeInfoByEmpId

        #region GetScheduleImportData
        /// <summary>
        /// GetScheduleImportData
        /// </summary>
        /// <returns></returns>
        public DataTable GetScheduleImportData()
        {
            EmpDAL objEmp = new EmpDAL();
            //objEmp.FromDate = FromDate;
           // objEmp.ToDate = ToDate;
            objEmp.WorkLocation = WorkLocation;

            DataTable dt = objEmp.GetScheduleImportData();
            return dt;
        }
        #endregion GetScheduleImportData


        #region GetShiftMaster
        /// <summary>
        /// GetShiftMaster
        /// </summary>
        /// <returns></returns>
        public DataTable GetShiftMaster()
        {
            EmpDAL objEmp = new EmpDAL();
            DataTable dt = objEmp.GetShiftMaster();
            return dt;
        }
        #endregion GetShiftMaster


        #region SaveSchedule
        /// <summary>
        /// SaveSchedule
        /// </summary>
        /// <returns></returns>
        public bool SaveSchedule()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.DtSource = DtSource;
            bool Result = objEmp.SaveSchedule();
            return Result;
        }
        #endregion SaveSchedule

        #region GetEmpSchedule
        /// <summary>
        /// GetEmpSchedule
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmpSchedule()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.FromDate = FromDate;
            objEmp.ToDate = ToDate;
            objEmp.WorkLocation = WorkLocation;
            DataTable dt = objEmp.GetEmpSchedule();
            return dt;
        }
        #endregion GetEmpSchedule


        #region GetAttendance
        /// <summary>
        /// GetAttendance
        /// </summary>
        /// <returns></returns>
        public DataTable GetAttendance()
        {
            EmpDAL objEmp = new EmpDAL();

            objEmp.FromDate = FromDate;
            objEmp.ToDate = ToDate;
            objEmp.WorkLocation = WorkLocation;
            objEmp.EmpId = EmpId;

            DataTable dt = objEmp.GetAttendance();
            return dt;
        }
        #endregion GetAttendance

        #region GetRemarks
        /// <summary>
        /// Get Remarks
        /// </summary>
        /// <returns></returns>
        public DataTable GetRemarks()
        {
            EmpDAL objEmp = new EmpDAL();
            DataTable dt = objEmp.GetRemarks();
            return dt;
        }
        #endregion GetRemarks

        #region GetLogin
        /// <summary>
        /// Get Login
        /// </summary>
        /// <returns></returns>
        public DataTable GetLogin()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.EmpId = EmpId;
            objEmp.Password = Password;
            DataTable dt = objEmp.GetLogin();
            ExceptionMessage = objEmp.ExceptionMessage;
            return dt;
        }
        #endregion GetLogin

        #region SaveAttendance
        /// <summary>
        /// SaveAttendance
        /// </summary>
        /// <returns></returns>
        public bool SaveAttendance()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.DtSource = DtSource;
            bool Result = objEmp.SaveAttendance();
            return Result;
        }
        #endregion SaveAttendance

        #region UpdateAttendanceLine
        /// <summary>
        /// UpdateAttendanceLine
        /// </summary>
        /// <returns></returns>
        public bool UpdateAttendanceLine()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.DtSource = DtSource;
            bool Result = objEmp.UpdateAttendaceReportLine();
            return Result;
        }
        #endregion UpdateAttendanceLine


        #region GetAttendanceLine
        /// <summary>
        /// GetAttendanceLine
        /// </summary>
        /// <returns></returns>
        public DataTable GetAttendanceLine()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.FromDate = FromDate;
            objEmp.ToDate = ToDate;
            objEmp.WorkLocation = WorkLocation;
            DataTable dt = objEmp.GetAttendanceLine();
            return dt;
        }
        #endregion GetAttendanceLine


        #region GetAttendanceLineByDate
        /// <summary>
        /// GetAttendanceLineByDate
        /// </summary>
        /// <returns></returns>
        public DataTable GetAttendanceLineByDate()
        {
            EmpDAL objEmp = new EmpDAL();
            objEmp.Date = Date;
            objEmp.WorkLocation = WorkLocation;
            objEmp.ReportType = ReportType;
            DataTable dt = objEmp.GetAttendanceByDate();
            return dt;
        }
        #endregion GetAttendanceLineByDate

        #region GetServerDate
        /// <summary>
        ///Get Server Date
        /// </summary>
        /// <returns></returns>
        public DataTable GetServerDate()
        {
            DataTable dtEmp = null;
            try
            {
                EmpDAL objEmp = new EmpDAL();
                dtEmp = objEmp.GetServerDate();
            }
            catch (Exception e)
            {

            }
            return dtEmp;
        }
        #endregion GetServerDate


        #region ImportEmployeeData
        /// <summary>
        /// ImportEmployeeData
        /// </summary>
        /// <returns>Result</returns>
        public bool ImportEmployeeData()
        {
            bool Result = false;
            try
            {
                EmpDAL objStock = new EmpDAL();
                objStock.DtSource = DtSource;
                objStock.ImportEmployeeData();
                ExceptionMessage = objStock.ExceptionMessage;

                if (null != ExceptionMessage && ExceptionMessage.ToString().Length > 0)
                {
                    Result = false;
                }
                else
                {
                    Result = true;
                }
            }
            catch (Exception e)
            {
                //Common.LogException("Role.cs", "BAL/Role.cs/GetAllActiveRoles", e.Message);
            }
            return Result;
        }
        #endregion ImportEmployeeData

        #region GetStore
        /// <summary>
        ///GetStore
        /// </summary>
        /// <returns></returns>
        public DataTable GetStore()
        {
            DataTable dtEmp = null;
            try
            {
                EmpDAL objEmp = new EmpDAL();
                dtEmp = objEmp.GetStore();
            }
            catch (Exception e)
            {

            }
            return dtEmp;
        }
        #endregion GetStore

        #region GetEmpDetailsById
        /// <summary>
        ///GetEmpDetailsById
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmpDetailsById()
        {
            DataTable dtEmp = null;
            try
            {
                EmpDAL objEmp = new EmpDAL();
                objEmp.EmpId = EmpId;
                dtEmp = objEmp.GetEmpDetailsById();
            }
            catch (Exception e)
            {

            }
            return dtEmp;
        }
        #endregion GetEmpDetailsById

        #region InsertOffer
        /// <summary>
        /// InsertOffer
        /// </summary>
        /// <returns></returns>

        public bool InsertOffer()
        {
            EmpDAL objOffer = new EmpDAL();

            objOffer.OfferCode = OfferCode;
            objOffer.MobileNo = MobileNo;
            objOffer.ValidUntil = ValidUntil;

            bool Result = objOffer.InsertOffer();

            return Result;
        }

        #endregion InsertOffer

        #region GetCustomer
        /// <summary>
        ///GetCustomer
        /// </summary>
        /// <returns></returns>
        public DataTable GetCustomer()
        {
            DataTable dtEmp = null;
            try
            {
                EmpDAL objEmp = new EmpDAL();
                dtEmp = objEmp.GetCustomer();
            }
            catch (Exception e)
            {

            }
            return dtEmp;
        }
        #endregion GetCustomer

        #region GetOfferCode
        /// <summary>
        ///GetOfferCode
        /// </summary>
        /// <returns></returns>
        public DataTable GetOfferCode()
        {
            DataTable dtEmp = null;
            try
            {
                EmpDAL objEmp = new EmpDAL();
                objEmp.MobileNo = MobileNo;
                dtEmp = objEmp.GetOfferCode();
            }
            catch (Exception e)
            {

            }
            return dtEmp;
        }
        #endregion GetOfferCode

        #region UpdateOffer
        /// <summary>
        /// UpdateOffer
        /// </summary>
        /// <returns></returns>

        public bool UpdateOffer()
        {
            EmpDAL objOffer = new EmpDAL();

            objOffer.OfferCode = OfferCode;
            objOffer.MobileNo = MobileNo;
            objOffer.StoreLocation = StoreLocation;

            bool Result = objOffer.UpdateOffer();

            return Result;
        }

        #endregion UpdateOffer

        #endregion Methods

    }
}