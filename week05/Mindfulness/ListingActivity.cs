using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "What are some goals or dreams you are excited to achieve?",
            "Who are the family members or friends that always make you smile?",
            "What are some small daily habits that improve your mood?",
            "What are things in nature or around you that you feel peaceful viewing?",
            "What skills or hobbies are you proud of developing over time?"
        };

        public ListingActivity() : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            int duration = GetDuration();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            int itemCount = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemCount++;
                }
            }

            Console.WriteLine($"You listed {itemCount} items!");
            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}