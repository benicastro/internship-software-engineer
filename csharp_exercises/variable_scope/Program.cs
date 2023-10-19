// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine("Outside of code block: " + value);

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = true;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
       found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");