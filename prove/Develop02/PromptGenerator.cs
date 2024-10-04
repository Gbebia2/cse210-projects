using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the most interesting part of my day?",
            "How did I involve God in my life today?",
            "Which person made me the most excited today?",
            "What didn't I do today that I wish I had done?",
            "What did I do today that I wish I hadn't done?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}