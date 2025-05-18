using System;
using System.Collections.Generic;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "What was I grateful for today?",
        "How did I see the Lord in my life today?",
        "What is something I will improve on tomorrow?",
        "What is something I want to accomplish this week?",
        "What did you study in the scriptures today?",
        "Share insights from a general conference talk you read recently.",
    };
    public string GetRandomPrompt() 
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}