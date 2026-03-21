public class Entry
// Write a new entry - Show the user a random prompt (from a list that you create),
//  and save their response, the prompt, and the date as an Entry.
{

    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}-{_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();

    }
}