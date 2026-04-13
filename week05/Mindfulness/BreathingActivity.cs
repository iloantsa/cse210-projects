

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing"
            )       
    {
        
    }
    protected override void Run()
    {


        int elapsedTime = 0;
        while (elapsedTime < _duration)

        {
            BreathIn(5);
            BreathOut(5);
            elapsedTime += 10;
        }


    }
    private void BreathIn(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rBreath in...{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    private void BreathOut(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rNow breath out...{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

    }



}

