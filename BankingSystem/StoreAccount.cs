using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class StoreAccount : Account
    {
        public string StoreName { get; set; }
        public AccountCategoryID AccountCategory { get; set; }

        public StoreAccount(string customerName) : base(customerName) // Kalw ton constructor tou patera Account
        {
            AccountCategory = AccountCategoryID.Senior;
        }

        public bool Valuation(AccountCategoryID AccountCategory)

        {


            if (Balance <= 1000 && AccountCategory == AccountCategoryID.Basic)
            {
                return true;
            }

            else if (Balance <= 5000 && AccountCategory == AccountCategoryID.Mid)
            {
                return true;
            }

            else if (Balance <= 10000 && AccountCategory == AccountCategoryID.Senior)
            {
                return true;
            }

            else if (Balance > 10000 && AccountCategory == AccountCategoryID.Lead)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }


   


}
