﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Datetime!");

        // Current date and time
        Console.WriteLine(DateTime.Now);

        // Date components
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);

        // Time components
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        // Other date and time properties
        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        // Date and time manipulation
        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(2));
        Console.WriteLine(DateTime.Now.AddYears(20));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        // Date formatting
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));
        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));
        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));

        // Math library
        Console.WriteLine(Math.Abs(-25));
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));
        Console.WriteLine(Math.Ceiling(22.3));
        Console.WriteLine(Math.Round(22.3));
        Console.WriteLine(Math.Round(22.7));
        Console.WriteLine(Math.Floor(22.7));
        Console.WriteLine(Math.Max(2, 6));
        Console.WriteLine(Math.Min(2, 6));
        Console.WriteLine(Math.Pow(3, 4));
        Console.WriteLine(Math.Sqrt(12));
        Console.WriteLine(Math.Log(12));
        Console.WriteLine(Math.Exp(3));
        Console.WriteLine(Math.Log10(20));
    }
}
