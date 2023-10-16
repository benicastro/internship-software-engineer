﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var cube = new Cube(); 
var triangle = new Triangle();
var rectangle = new Rectangle();

Console.Write("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Width: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height: ");
int width = Convert.ToInt32(Console.ReadLine());

rectangle.Length = length;
rectangle.Height = height;
rectangle.Width = width;   

Console.WriteLine($"The volume of the rectangular prism is: {rectangle.getVolume()} cubic meters.");