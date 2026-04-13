
using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine();


        Console.Write("How long, in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());


        Console.WriteLine("Get Ready...");
        ShowAnimation(3);

        

        Console.WriteLine();
        Console.WriteLine($"Well done!");
        Console.WriteLine($"You spent {_duration} seconds in the {_name} Activity");
        
        ShowAnimation(3);
    }
    protected abstract void Run();
    protected void ShowAnimation(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write($"\r{animationString[i % animationString.Count]}");
            i++;
            Thread.Sleep(300);
        }
        Console.Write("\r ");
    }
}    



