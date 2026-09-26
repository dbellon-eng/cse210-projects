/* I exceeded the requirements by adding a scripture library. 
Instead of showing only one scripture, I created a list with multiple 
passages (single and multi-verse). The program picks one at random 
every time it starts.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("2 Nephi", 2, 24, 25),
                "But behold all things have been done in the wisdom of him who knoweth all things Adam fell that men might be and men are that they might have joy"
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            )
        };

        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();

            if (currentScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.Trim().ToLower() == "quit")
            {
                break;
            }

            currentScripture.HideRandomWords(3);
        }
    }
}