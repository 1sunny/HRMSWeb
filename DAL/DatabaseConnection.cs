#region Namespaces

using System;
using System.Configuration;
using System.Data.SqlClient;

#endregion Namespaces

namespace HRMSWeb.DAL
{
    public class DatabaseConnection
    {
        #region Properties

        /// <summary>
        /// Properties for cnDbConnection.
        /// </summary>

        public SqlConnection CnDbConnection
        {
            get;
            set;
        }

        /// <summary>
        /// Db Connection Failure Message
        /// </summary>
        public string DbConnectionFailureMessage
        {
            get;
            set;
        }

        /// <summary>
        /// dbCntStr
        /// </summary>
        public string dbCntStr
        {
            get;
            set;
        }

        #endregion Properties

        #region Constructor

        #region DbConnection
        /// <summary>
        /// Constructor for DbConnection class.  In this constructor
        /// database connection to cnDbConnection is initialised.
        /// </summary>
        public DatabaseConnection()
        {

            try
            {
                 dbCntStr = (null != ConfigurationManager.ConnectionStrings["HRMSConnectionString"])
                    ? ConfigurationManager.ConnectionStrings["HRMSConnectionString"].ConnectionString : "";
                 CnDbConnection = new SqlConnection(dbCntStr);

                if ((null != CnDbConnection) && (CnDbConnection.ConnectionString.Trim().Length > 0))
                {
                    CnDbConnection.Open();
                    DbConnectionFailureMessage = "";
                }
                else
                {
                    DbConnectionFailureMessage = "Unable to establish DB connection";
                }
            }
            catch (SqlException ex)
            {
                DbConnectionFailureMessage = "Server Error!!! " + ex.Message;
            }
        }
        #endregion DbConnection



        #region MatalanDbConnection
        /// <summary>
        /// Constructor for DbConnection class.  In this constructor
        /// database connection to cnDbConnection is initialised.
        /// </summary>
        public DatabaseConnection(int Matalan)
        {

            try
            {


                string dbCntStr = (null != ConfigurationManager.ConnectionStrings["MatalanConnectionString"])
                     ? ConfigurationManager.ConnectionStrings["MatalanConnectionString"].ConnectionString : "";


                CnDbConnection = new SqlConnection(dbCntStr);

                if ((null != CnDbConnection) && (CnDbConnection.ConnectionString.Trim().Length > 0))
                {
                    CnDbConnection.Open();
                    DbConnectionFailureMessage = "";
                }
                else
                {
                    DbConnectionFailureMessage = "Unable to establish DB connection";
                }
            }
            catch (SqlException ex)
            {
                DbConnectionFailureMessage = "Server Error!!! " + ex.Message;
            }
        }
        #endregion MatalanDbConnection


     

        #endregion Constructor

        #region Public Method

        #region CloseDbConnection
        /// <summary>
        /// Method for closing sqldbconnection. Each time 
        /// the connection is used it must be closed.
        /// </summary>
        public void CloseDbConnection()
        {
            if ((null != CnDbConnection) && (CnDbConnection.State != System.Data.ConnectionState.Closed))
            {
                CnDbConnection.Close();
            }
        }
        #endregion CloseDbConnection

        #endregion Public Method
    }
}