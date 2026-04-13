public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts;
    private List<string> _items;


    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area"
        )
    {
        _prompts = new List<string>()
        {


            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
        _items = new List<string>();
        _count = 0;


    }
    protected override void Run()
    {
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("Start listing items. Keep typing until time is up:");


        Console.WriteLine();

        GetListFromUser();
        Console.WriteLine($"You listed {_count} items");

    }


    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];

    }

    private void GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    _items.Add(input);
                }
            }
        }




    }

}


