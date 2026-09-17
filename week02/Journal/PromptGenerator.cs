using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was a challenge I faced today, and how did I handle it?",
        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I see the hand of the Lord in my life today?",
        "Who did I help today, or who helped me?"
    };
    public string GetRandomPrompt()
    {
        Random random =new Random ();
        int index =random.Next(_prompts.Count);
        return _prompts[index];
    }
}

   
