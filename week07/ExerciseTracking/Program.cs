using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("15 March 2026", 30, 5),
            new Cycling("15 March 2026", 30, 10),
            new Swimming("15 March 2026", 30, 20)

        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}