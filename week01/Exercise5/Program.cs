using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name=PromptUserName();
        int fav_number=PromptUserNumber();
        int square=SquareNumber(fav_number);
        DisplayResult(user_name,square);
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        } 
    static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name=Console.ReadLine();

            return user_name;
        }
    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int fav_number =int.Parse(Console.ReadLine());
            return fav_number;
        }

      static int SquareNumber(int fav_number)
    {
        int square = fav_number * fav_number;
        return square;
    }

    static void DisplayResult(string user_name, int square)
    {
        Console.WriteLine($"{user_name}, the square of your number is {square}");
    }
    
}