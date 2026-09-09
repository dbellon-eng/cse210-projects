using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =new List<int>();
        int user_number=-10;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (user_number!=0)
        {
          Console.Write("Enter number: ");
            string response=Console.ReadLine();
            user_number=int.Parse(response);

            if (user_number!=0)
            {
                numbers.Add(user_number);
            }
        }  

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        float avg= ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max= numbers[0];
        foreach (int number in numbers)
        {
            if (number>max)
            {
                max=number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
        
}