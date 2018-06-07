using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21stCenturyStadium
{
    /// <summary>
    /// Member account
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique account number
        /// for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email address of the user
        /// associated with the account
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Type of account user signed up for
        /// </summary>
        public string TypeOfAccount { get; set; }
        #endregion
    }
}
