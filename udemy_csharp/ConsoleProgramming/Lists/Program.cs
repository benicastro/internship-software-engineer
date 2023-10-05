// See https://aka.ms/new-console-template for more information

// Declare
List<string> names = new List<string>();
string name = string.Empty;

// Add values to list
names.Add("Castro");
//names.Remove("Beni");


while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }   
}

// Print values in list
foreach (string addedName in names)
{
    Console.WriteLine(addedName);
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}