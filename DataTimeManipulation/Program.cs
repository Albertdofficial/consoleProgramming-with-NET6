// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Hello, World!");

// Empty DateTime
DateTime date = new DateTime();

// create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1999, 10, 10);

Console.WriteLine($"My DOB is: {dateOfBirth}");

// create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The Time Now is: {now}");

// Create a DateTime from a string
DateTime datefromString = DateTime.Parse("1/31/2023", CultureInfo.InvariantCulture);
Console.WriteLine($"The Date from now is: {datefromString}");

// Additional Time
Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
Console.WriteLine($"One day from now is: {now.AddDays(1)}");

// Ticks from DateTime
Console.WriteLine($"Ticks as a numeral: {now.Ticks}");

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"Date Only: {dateOnlyOfBirth}");

// Time Only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(now);
Console.WriteLine($"Time Only: {timeOnlyOfBirth}");
