// See https://aka.ms/new-console-template for more information
using System.Globalization;

// Empty DateTime
DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1995, 06, 02);
Console.WriteLine($"Your date of birth is {dateOfBirth.Date}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {dateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {dateOfBirth.Ticks}");
Console.WriteLine($"Kind: {dateOfBirth.Kind}");


// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The date and time right now is {now}.");

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2031", CultureInfo.InvariantCulture);
Console.WriteLine($"The date from the string is {dateFromString}");

// Add Additional Time
Console.WriteLine($"One hour from now is {now.AddHours(1)}.");
Console.WriteLine($"One day from now is {now.AddDays(1)}.");

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Time only: " + timeOnlyOfBirth);