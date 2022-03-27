﻿using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
doApp();

static void doApp()
{
    DateTime dt = DateTime.Now;
    Console.WriteLine("Current date and time :" + dt.ToString());
    Console.WriteLine("Formatted short date:" + dt.ToShortDateString());
    Console.WriteLine("Formatted short date:" + dt.ToLongDateString());
    Console.WriteLine("Current date and time :" + dt.ToString("d"));
    Console.WriteLine("Current date and time :" + dt.ToString("D"));
    Console.WriteLine("Current date and time :" + dt.ToString("F"));
    Console.WriteLine("Current date and time :" + dt.ToString("y"));

    Console.WriteLine("Adding 5 days to today:" + dt.AddDays(5).ToShortDateString());

    DateTime date1 = new DateTime(2022, 1, 2, 4, 0, 15);
    DateTime date2 = new DateTime(2022, 1, 2, 14, 0, 15);
    TimeSpan value = date1.Subtract(date2);
    Console.WriteLine("TimeSpan between two dates is {0} hours", value);

    return;

}