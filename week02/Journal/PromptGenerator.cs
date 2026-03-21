
public class PromptGenerator

{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who did you talk to today?",
        "What made you smile today?",
        "What did you learn today?",
        "What are you grateful for?"
    };

    
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1, 6);
        return (_prompts[index]);
    }


}