// See https://aka.ms/new-console-template for more information

/*
 * Prototype - defines the function (type, name, parameters)
 * Definition - has the code, contains the code block
 * Function Call - executes the function
*/

// DRY - Don't Repeat Yourself
// YAGNI - You Aren't Going to Need It

// Void Functions

Console.WriteLine();

void PrintName(string name)
{
    Console.WriteLine(name);
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}.");
}

PrintName("Beni");
Addition(5, 7);
Console.WriteLine();

// Value Returning Functions

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
    {
        largest = num2;
    }

    if (largest < num3)
    {
        largest = num3;
    }

    return largest;
}

int result = LargestNumber(num1, num2, num3);
Console.WriteLine($"The largest number is {result}.");