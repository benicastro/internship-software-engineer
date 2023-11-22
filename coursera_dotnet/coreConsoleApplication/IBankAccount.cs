using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    interface IManageBank
    {
        void openAccount();
        void closeAccount();
    }
    internal interface IBankAccount
    {
        void deposit();
        void withdraw();
        void balance();

    }

    public class SavingsAcc : IBankAccount, IManageBank
    {
        public void balance()
        {
            Console.WriteLine("Balance in Savings Account");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Savings Account");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Savings Account");
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Savings Account");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from Savings Account");
        }
    }
}
