using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the biggest mistake you made today?", 
        "What did you learn today?",
        "What is the funniest thing that happened to you today?",
        "What goals did you accomplish today?",
        "Have you done any good in the world today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        return _prompts[randomPrompt];
    }
}