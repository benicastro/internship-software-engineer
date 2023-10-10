// See https://aka.ms/new-console-template for more information

// Primitive Data Types - int, string, bool, char

// Object-Oriented Programming - creating your own data type
// Class - blueprint

// Single Responsibility Principle

using ClassesAndObjects;

Person person =  new();

Console.Write("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

person.setSalary(salary);

Console.WriteLine($"Full name is: {person.getFullName()}");
Console.WriteLine($"Age is: {person.Age}");
Console.WriteLine($"Salary is: {person.getSalary()}");