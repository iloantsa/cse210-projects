using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)

        {
            
            Console.WriteLine($"Welcome to the Mindfulness Project!");

            Console.WriteLine($"Menu option:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. start Listing Activity");

            Console.WriteLine("4.Quit");
            Console.Write($"select a choice from the Menu: ");
            choice = int.Parse(Console.ReadLine());
            Activity activity = null;


            if (choice == 1)
            {

                activity = new BreathingActivity();


            }
            else if (choice == 2)
            {
                activity = new ReflectingActivity();

            }
            else if (choice == 3)
            {

                activity = new ListingActivity();

            }

            if (activity != null)
            {
                activity.Start(); 
            }

        }

    }
}        