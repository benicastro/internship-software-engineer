// See https://aka.ms/new-console-template for more information
//using System.Text;

//Console.WriteLine("Hello, World!");

//StringBuilder sb = new StringBuilder();


using coreConsoleApplication;

SavingsAccount savingsAccount = new SavingsAccount();

savingsAccount.getMessage();

savingsAccount.deposit();
savingsAccount.withdraw();
savingsAccount.balance();

Console.WriteLine();

SavingsAcc savingAcc = new SavingsAcc();

savingAcc.openAccount();
savingAcc.closeAccount();
savingAcc.balance();
savingAcc.withdraw();
savingAcc.deposit();