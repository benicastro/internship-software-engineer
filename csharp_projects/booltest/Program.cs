// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Boolean Expressions

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// // String Methods
// /*
// ToUpper()
// ToLower()
// Trim()
// Contains()
// StartsWith()
// EndsWith()
// */

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// Challenge ////////////////////////////////////////////////////////////////////////////////////////////////

// Random random = new Random();
// string result;

// result = random.Next(0, 2) == 1 ? "heads" : "tails";
// Console.WriteLine(result);

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin") & level > 55)
// {
//     Console.WriteLine("Welcomr, Super Admin user.");
// }
// else if (permission.Contains("Admin") & level <= 55)
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if (permission.Contains("Manager") & level >= 20)
// {
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if (permission.Contains("Manager") & level < 20)
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
}

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}