using System;

class Program
{
    static void Main(string[] args)
    {
        string play ="yes";
        while (play.ToLower()== "yes")
        {
            //Console.Write("What is the magic number? ");
            //int magic= int.Parse(Console.ReadLine());
            Random randomGenerator =new Random();
            int magic=randomGenerator.Next(1,101);

            int guess=-10;
            while(guess!= magic)
            {
                Console.Write("What is your guess? ");
                guess= int.Parse(Console.ReadLine());
            
                if (magic>guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magic<guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine("Do you want to play again (yes / no)? ");
            play= Console.ReadLine();
            Console.WriteLine();

        }
        
    }
}