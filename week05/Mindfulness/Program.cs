// I added a counter system to track how many times the user completes each activity 
// during the session. The user can see these stats in option 4 of the main menu.

using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            int breathingCount = 0;
            int reflectingCount = 0;
            int listingCount = 0;

            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. View session stats");
                Console.WriteLine("  5. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        breathingCount++;
                        break;
                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        reflectingCount++;
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        listingCount++;
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Session Statistics:");
                        Console.WriteLine($"  Breathing Activities completed: {breathingCount}");
                        Console.WriteLine($"  Reflecting Activities completed: {reflectingCount}");
                        Console.WriteLine($"  Listing Activities completed: {listingCount}");
                        Console.WriteLine("\nPress Enter to return to the menu...");
                        Console.ReadLine();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}