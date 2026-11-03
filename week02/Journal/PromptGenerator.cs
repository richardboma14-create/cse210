public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "Who made you smile today, and why?",
        "What is one thing you learned today?",
        "What challenged you today, and how did you handle it?",
        "What are you grateful for today?",
        "How did you see the hand of the Lord in your life today?",
        "If you could relive one moment today, what would it be?",
        "What is one thing you want to improve tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}