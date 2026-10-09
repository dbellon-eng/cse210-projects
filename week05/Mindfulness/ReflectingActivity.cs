using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you overcame a major fear.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped a friend or family member solve a problem."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "What character trait helped you the most in that moment?",
            "How can you apply what you learned to your life today?"
        };

        public ReflectingActivity() : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("\nConsider the following prompt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            int duration = GetDuration();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write($"> {GetRandomQuestion()} ");
                ShowSpinner(5);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(_questions.Count);
            return _questions[index];
        }
    }
}