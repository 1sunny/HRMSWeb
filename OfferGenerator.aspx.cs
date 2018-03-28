#region NameSpace
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRMSWeb.BAL;
#endregion NameSpace

namespace HRMSWeb
{
    public partial class OfferGenerator : System.Web.UI.Page
    {
        static Random random = new Random();

        #region Events

        #region Page_Load
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion Page_Load

        #region btnGenerate_Click
        /// <summary>
        /// btnGenerate_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGenerate_Click(object sender, EventArgs e)
        {

            EmpBL ObjEmp = new EmpBL();
            DataTable dt=ObjEmp.GetCustomer();
            int vouchersToGenerate = dt.Rows.Count;
            int lengthOfVoucher = 5;

            List<string> generatedVouchers = new List<string>();
            char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            //  Console.WriteLine("Vouchers: ");
            int i = 0;
            while (generatedVouchers.Count < vouchersToGenerate)
            {
                var voucher = GenerateVoucher(keys, lengthOfVoucher);
                if (!generatedVouchers.Contains(voucher))
                {
                    generatedVouchers.Add(voucher);

                    ObjEmp.OfferCode = voucher;
                    ObjEmp.ValidUntil = Convert.ToDateTime(txtValidUntil.Text.Trim().ToString());
                        //DateTime.ParseExact(txtValidUntil.Text.Trim().ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); 
                    ObjEmp.MobileNo = Convert.ToDecimal(dt.Rows[i]["MobileNo"].ToString());
                    bool Result = ObjEmp.InsertOffer();

                    if (Result)
                     i++;
                    //Console.WriteLine("\t[#{0}] {1}", generatedVouchers.Count, voucher);
                }
            }
          
        }
        #endregion btnGenerate_Click

        #endregion Events

        #region Methods

        #region GenerateVoucher
        /// <summary>
        /// GenerateVoucher
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="lengthOfVoucher"></param>
        /// <returns></returns>
        private static string GenerateVoucher(char[] keys, int lengthOfVoucher)
        {
            return Enumerable
                .Range(1, lengthOfVoucher) // for(i.. ) 
                .Select(k => keys[random.Next(0, keys.Length - 1)])  // generate a new random char 
                .Aggregate("", (e, c) => e + c); // join into a string
        }
        #endregion GenerateVoucher

        #endregion Methods
    }
}