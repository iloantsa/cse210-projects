using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);
        string letter = "";
        // Get the last digit
        float lastDigit = x % 10;
        string sign = "";

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
            letter = "D";


        }

        else
        {
            letter = "F";
        }
       
        //determine the sign
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit< 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle exception(A+, F+, F-)
        if (letter == "A" && sign == "+" || letter == "F" )
        {
            sign = "";


        }


        Console.WriteLine($"You have earned the grade {letter}{sign}");
        if (x >= 70)
        {
            Console.WriteLine($"Congratulation!, You passed the course.");
        }
        else 

        {
            Console.WriteLine($"Sorry! Please try the course again.");
        }

    }
}