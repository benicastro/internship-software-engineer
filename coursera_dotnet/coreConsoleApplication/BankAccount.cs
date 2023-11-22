using System;

namespace coreConsoleApplication
{
    public abstract class BankAccount
    {
        public void getMessage()
        {
            Console.WriteLine("Welcome to Astroc Bank!");
        }
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    public class SavingsAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Savings Account");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Savings Account");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from Savings Account");
        }
    }
}