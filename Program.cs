using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Time Converter!");

        // Taking input from the user
        Console.Write("Enter the number of seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        // Converting seconds to minutes
        int minutes = seconds / 60;

        // Converting minutes to hours
        int hours = minutes / 60;

        // Converting hours to days
        int days = hours / 24;

        // Converting days to months
        int months = days / 30;

        // Displaying the converted time
        Console.WriteLine($"Converted time:");
        Console.WriteLine($"Seconds to Minutes: {minutes}");
        Console.WriteLine($"Minutes to Hours: {hours}");
        Console.WriteLine($"Hours to Days: {days}");
        Console.WriteLine($"Days to Months: {months}");

        Console.WriteLine("Thank you for using the time converter!");
    }
}
