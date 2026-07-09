using System;

class Assignment3
{
    static void Main()
    {
        // Array storing monthly sales of 6 employees
        int[] sales = { 25000, 30000, 28000, 35000, 27000, 32000 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        // Display sales and calculate values
        Console.WriteLine("Monthly Sales:");

        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": ₹" + sales[i]);

            total += sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }

        // Calculate average
        double average = total / (double)sales.Length;

        // Display results
        Console.WriteLine("\nTotal Sales = ₹" + total);
        Console.WriteLine("Average Sales = ₹" + average);
        Console.WriteLine("Highest Sales = ₹" + highest);
        Console.WriteLine("Lowest Sales = ₹" + lowest);
    }
}