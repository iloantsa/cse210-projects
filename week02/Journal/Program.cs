using System;

class Program
{
    static void Main(string[] args)

    {
        
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        PromptGenerator p = new PromptGenerator();
        
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine($"Welcome to the journal program!");

            Console.WriteLine($"Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = p.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new Entry
                {

                    _date = dateText,
                    _promptText = prompt,
                    _entryText = response,



                };
                theJournal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                
                Console.WriteLine($"What is the file name? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);

            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

        }
    
    } 
}    