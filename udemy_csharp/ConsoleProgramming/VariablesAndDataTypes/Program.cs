// See https://aka.ms/new-console-template for more information

// Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working;

// Prompt user
Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please input your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please input your gender: (M | F)");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("You are already working: (true | false)");
working = Convert.ToBoolean(Console.ReadLine());

// Print information
Console.WriteLine($"Your name is {fullName}.");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"You have a salary of {salary}$.");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Are you working now?: {working}");