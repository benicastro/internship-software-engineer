// See https://aka.ms/new-console-template for more information

// For Loop (Counter-controlled)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("Loop finished...");

// While Loop (Condition-controlled - Pre-check)
int counter = 0;
while (counter < 10)
{
    Console.Write("Please enter a number: ");
    counter = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {counter}.");

}

//Console.WriteLine("You broke out from the while loop!");

// Do-While Loop (Condition-controlled - Post-check)
int n = 11;
do
{
    n++;
    Console.WriteLine($"\n\n{n}");
} while (n < 10);

//Foreach
string[] fruits = { "apple", "orange", "mango" };
foreach (string fruit in fruits)
{
    Console.WriteLine($"\nI want to eat a/an {fruit}.");
}

