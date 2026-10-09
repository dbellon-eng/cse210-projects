using System;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base(
            "Breathing Activity",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();
            int duration = GetDuration();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe in...");
                ShowCountDown(4);
                Console.WriteLine();

                if (DateTime.Now >= endTime) break;

                Console.Write("Breathe out...");
                ShowCountDown(6);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}