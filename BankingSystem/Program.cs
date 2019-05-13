using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            var dimitris = new Account("Dimitris Gianakopoulos");


            dimitris.Deposit(1000);
            Withdraw(100, dimitris );
            Withdraw(100, dimitris);
            Withdraw(100, dimitris);

            var trump = new StoreAccount("Donald");
            trump.Deposit(1000);
            bool success = trump.Valuation(AccountCategoryID.Basic);
            if (success) Console.WriteLine("You can");
            else Console.WriteLine("You cannot :(");


            Console.ReadLine();

        }

        public static void Withdraw(decimal amount, Account account)
        {
            var success = account.WithDraw(amount);

            HandleTransactionResult(account, success);

        }

        public static void Deposit(decimal amount, Account account)
        {
            var success = account.Deposit(amount);


            HandleTransactionResult(account, success);

        }

        public static void HandleTransactionResult(Account account,
            bool transactionResult)
        {
            if (transactionResult)
            {
                Console.WriteLine($" Your new balnce is: {account.Balance}, Your new number of transaction is : {account.NumberOfTransactions}");

            }
            else
            {

                Console.WriteLine("Deposit not successfull :(");

            }
        }



    }
}
