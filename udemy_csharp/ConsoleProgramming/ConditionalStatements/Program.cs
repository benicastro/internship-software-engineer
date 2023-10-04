// See https://aka.ms/new-console-template for more information

Console.Write("Enter First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// If Statements ( == | < | > | <= | >= | !=
if (num1 > num2)
{
    Console.WriteLine($"The first number ({num1}) is greater than the second number ({num2})");
}
else if (num1 < num2)
{
    Console.WriteLine($"The first number ({num1}) is less than the second number ({num2})");
}
else
{
    Console.WriteLine("The two numbers are equal");
}

// Switch Statements
Console.Write("Enter Final Grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch (grade)
{
    case int n when (n == 100):
        Console.WriteLine("You got full marks.");
        break;
    case int n when (n >= 60):
        Console.WriteLine("You passed.");
        break;
    case int n when (n >= 0):
        Console.WriteLine("You failed.");
        break;
    default:
        Console.WriteLine("Invalid input!");
        break;
}

// Ternary
var message = num1 > num2 ? $"{num1} is greater than {num2}" : $"{num1} is less than {num2}";
Console.WriteLine(message);