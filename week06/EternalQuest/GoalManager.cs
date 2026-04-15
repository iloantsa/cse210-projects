
using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {


            Console.WriteLine($"Welcome to the Eternal Quest Project!");
            DisplayPlayerInfo();
            Console.WriteLine($"Menu option:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write($"Select a choice from the Menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

                CreateGoal();

            }
            else if (choice == 2)
            {

                ListGoalDetails();

            }
            else if (choice == 3)
            {
                Console.Write("What is the file name? ");
                SaveGoals(Console.ReadLine());


            }
            else if (choice == 4)
            {

                Console.Write($"What is the file name? ");
                LoadGoals(Console.ReadLine());

            }
            else if (choice == 5)
            {
                RecordEvent();

            }
        }

    }    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");

    }
    public void CreateGoal()
    {
        Console.WriteLine($"The type of goal are:");
        Console.WriteLine($"1. Simple Goal");
        Console.WriteLine($"2. Eternal Goal");
        Console.WriteLine($"3.Checklist Goal");
        Console.Write($"Which type of Goal would you to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write($"What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));

        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));

        }
        else if (choice == 3)
        {
            Console.Write($"How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());


            Console.Write($"What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            

        }



    }
    public void ListGoalsName()
    {


        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }



    }
    public void ListGoalDetails()
    {

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }



    }


    public void RecordEvent()
    {

        ListGoalsName();
        Console.Write($"Which Goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations! You earned {points} points.");
        Console.WriteLine($"You now have {_score} points.");

    }
    public void SaveGoals(string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringPresentation());
            }
        }



    }
    public void LoadGoals(string filename)
    {

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);



        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])
                ));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3])
                ));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }

    }

}    


  
