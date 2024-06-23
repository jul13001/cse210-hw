public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the most amazing thing I experienced today?",
        "what bothered me the most today?",
        "How could I have done better? ",
        "What did I do well today?",
        "How did I exemplify Jesus Christ today?",
        "How did I see the Lord's hand?",
        "What am I most grateful for?",
        "What needs do I need to fulfill?"
    };
    public Random _rand = new Random();
    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}