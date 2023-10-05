// See https://aka.ms/new-console-template for more information

// Declare a fixed size array
int[] grades = new int[5];

// Add values to a fixed size array

//grades = new int[] { 97, 93, 93, 79, 86 };

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in a fixed size array
Console.WriteLine("The grades you entered are:");
foreach (int grade in grades)
{
    Console.WriteLine(grade);
}


// Declare a variable sized array
string[] studentNames = new string[] { "Student1", "Student2", "Student3"};
