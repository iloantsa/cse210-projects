using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number:");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
                numbers.Add(userNumber);



        }
        // compute the total
        int total = 0;

        foreach (int number in numbers) 
        {
            total += number;

        }
        Console.WriteLine($"The total is : {total}.");

        // compute the average 
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find the largest number 
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
        // Find the smallest positive number
        int smallest_positive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest_positive)
                smallest_positive = number;


        }
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");

        //Sort the numbers in the list and display the new, sorted list

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}


