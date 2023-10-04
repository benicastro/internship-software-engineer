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

// Value Returning Functions