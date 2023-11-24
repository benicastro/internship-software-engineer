// See https://aka.ms/new-console-template for more information
//using System.Text;

//Console.WriteLine("Hello, World!");

//StringBuilder sb = new StringBuilder();


using coreConsoleApplication;

//SavingsAccount savingsAccount = new SavingsAccount();

//savingsAccount.getMessage();

//savingsAccount.deposit();
//savingsAccount.withdraw();
//savingsAccount.balance();

//Console.WriteLine();

//SavingsAcc savingAcc = new SavingsAcc();

//savingAcc.openAccount();
//savingAcc.closeAccount();
//savingAcc.balance();
//savingAcc.withdraw();
//savingAcc.deposit();

//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.increment());
//Console.WriteLine(Calculate.decrement());

// Demonstrating Extension Methods

//int number = 100;
//bool result = number.IsGreaterThan(100);
//Console.WriteLine(result);

// Partial Classes and Methods

//var employee = new Employee();
//Console.WriteLine(employee.EmpId);
//Console.WriteLine(employee.EmpName);
//employee.DisplayDetails();

// Properties

//User user = new User();
//user.Name = "Test";
//user.Age = 30;

//Console.WriteLine(user.Name);
//Console.WriteLine(user.Age);
//Console.WriteLine(user.CompanyName);

// Indexer

//StringIndexerType stringIndexerType = new StringIndexerType();
//stringIndexerType[0] = "String One";
//stringIndexerType[1] = "String Two";
//stringIndexerType[2] = "String Three";
//stringIndexerType[3] = "String Four";

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(stringIndexerType[i]);
//}

// Enums

//EnumDemo enumDemo = new EnumDemo();
//enumDemo.display();

// Exception Handling

//Calculation calculation = new Calculation();
//calculation.calculate();

// Anonymous Types

//var obj = new
//{
//    firstName = "Beni",
//    lastName = "Castro",
//    age = 30,
//    address = new
//    {
//        cityName = "Cabanatuan",
//        provinceName = "Nueva Ecija"
//    },
//    projects = new[]
//    {
//        new { projectName = "C#", projectDuration = "20 hours"},
//        new { projectName = "Python", projectDuration = "20 hours"},
//        new { projectName = "SQL", projectDuration = "20 hours"}
//    }
//};

//Console.WriteLine(obj.firstName);
//Console.WriteLine(obj.lastName);
//Console.WriteLine(obj.age);
//Console.WriteLine(obj.address.cityName);
//Console.WriteLine(obj.address.provinceName);

//foreach (var project in obj.projects)
//{
//    Console.WriteLine(project.projectName + ":" + project.projectDuration);
//}

// Delegates

//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);

//c1(100);
//Console.WriteLine(DelegateExample.getNumber());

//c2(100);
//Console.WriteLine(DelegateExample.getNumber());

//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c1 += new CalculateDelegate(DelegateExample.multiplication);

//c1(100);
//Console.WriteLine(DelegateExample.getNumber());

// Events

// Subscriber Model
//EventsExample events = new EventsExample();
//events.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);
//events.addition();
//Console.ReadLine();

//static void EventMessage()
//{
//    Console.WriteLine("Event Executed: Odd Number");
//}

// Anonymous Methods

//AnonymousMethodExample.InvokeMethod();

// Lambda Expression