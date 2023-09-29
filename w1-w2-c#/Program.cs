// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // Float - suffix F
// // Decimal - suffix M

// string firstName;
// char userOption;
// int gameScore;
// decimal particlesPerMillion;
// bool processedCustomer;

// string firstName;
// firstName = "Bob";
// Console.WriteLine(firstName);
// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName);

// var message = "Hello World!";

// string firstName = "Bob";
// int numMessages = 3;
// double temp = 34.4;

// Console.Write("Hello, ");
// Console.Write(firstName);
// Console.Write("! You have ");
// Console.Write(numMessages);
// Console.Write(" messages in your inbox. The temperature is ");
// Console.Write(temp);
// Console.Write(" celsius.");

// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");
// Console.WriteLine("Hello\"World\"!");
// Console.WriteLine("c:\\source\\repos");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.WriteLine("\nOutput Directory:\t");
// Console.Write(@"c:\invoices");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");

// int version = 11;
// string updateText = "Update to Windows";
// Console.WriteLine($"{updateText} {version}!");

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

// string projectName = "ACME";
// Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// Console.WriteLine($"{russianMessage}\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

// string projectName = "ACME";
// string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
// Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
// Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

// int first = 7;
// int second = 5;
// decimal quotient = (decimal)first / (decimal)second;
// Console.WriteLine(quotient);

// Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// int value = 1;

// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value++;
// Console.WriteLine("Third increment: " + value);

// value = value - 1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

// int value = 1;
// value++;
// Console.WriteLine("First: " + value);
// Console.WriteLine($"Second: {value++}");
// Console.WriteLine("Third: " + value);
// Console.WriteLine("Fourth: " + (++value));

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32) * 5m / 9m;
// Console.WriteLine($"The temperature is {celsius} Celsius.");

// initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// // Console.WriteLine("Sophia: " + sophiaSum);
// // Console.WriteLine("Nicolas: " + nicolasSum);
// // Console.WriteLine("Zahirah: " + zahirahSum);
// // Console.WriteLine("Jeong: " + jeongSum);

// decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
// decimal jeongScore = (decimal) jeongSum / currentAssignments;

// // Console.WriteLine("Sophia: " + sophiaScore);
// // Console.WriteLine("Nicolas: " + nicolasScore);
// // Console.WriteLine("Zahirah: " + zahirahScore);
// // Console.WriteLine("Jeong: " + jeongScore);

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
// Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10) % 10;
// int secondDigit = (int) (gradePointAverage * 100 ) % 10;

// Console.WriteLine($"Student: {studentName}\n");
// Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
// Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}\n");
// Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");

// decimal x = 7 / 5;
// Console.WriteLine(x);

// using System;

// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Hello World!");    
//     }
//   }
// }
// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       int i = 0;
//       while (i < 5) 
//       {
//         Console.WriteLine(i);
//         i++;
//       }
//     }
//   }
// }

// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// for (int i = 0; i < numbers.GetLength(0); i++) 
// { 
//   for (int j = 0; j < numbers.GetLength(1); j++) 
//   { 
//     Console.WriteLine(numbers[i, j]); 
//   } 
// }  

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");