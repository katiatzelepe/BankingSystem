using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        public string CustomerName { get; private set; }
        public decimal Balance { get; private set; }
        public int NumberOfTransactions { get; private set; }


        public Account(string customerName)
        {
            CustomerName = customerName;
        }

        const decimal amountLimit = 5000;
        public bool Deposit(decimal amount)
        {
            if (amount > 0 && 
                amount < amountLimit)
            {
                NumberOfTransactions++;
                Balance += amount;
                return true;
            }
           
                return false;

        }


        public bool WithDraw(decimal amount)
        {
            if (amount > amountLimit || 
                amount > Balance || amount < 1)
            {
                return false;
            }

                NumberOfTransactions++;
                Balance -= amount;
                return true;
            
        }


    }
}
