// See https://aka.ms/new-console-template for more information

string firstName = "Benedict";
string lastName = "Castro";

// Print to screen
Console.WriteLine($"Your name is {firstName} {lastName}.");

// String length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long.");

// Replace string parts
string newName = firstName.Replace("t", "k");
Console.WriteLine($"Your new name is {newName}.");

// Split string
string[] splitName = firstName.Split('e');
foreach (string name in splitName)
{
    Console.WriteLine(name);
}

// Compare strings
string nullString = null;
string emptyString = "";
string whitespaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName ==  lastName)
{
    Console.WriteLine("Strings are equal.");
}

// Convert to string
string convertedString = string.Empty;
int number = 123;

convertedString = number.ToString();
Console.WriteLine($"The converted string is {convertedString}.");