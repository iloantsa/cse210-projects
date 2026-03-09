using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int Square = SquareNumber(userNumber);
        DisplayResult(userName, Square);

    }
    static void DisplayWelcome()

    {
        Console.WriteLine("Welcome to the Program!");
            
    }


    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write($"Please enter your favorite: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;


    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of you number is: {square}");

    }   
}




