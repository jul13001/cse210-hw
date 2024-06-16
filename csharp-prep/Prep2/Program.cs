using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your score?");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        if (number >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (number >= 80)
        {
            Console.WriteLine("You got a B.");
        }
        else if (number >= 70)
        {
            Console.WriteLine("You got a C.");
        }
        else if (number >= 60)
        {
            Console.WriteLine("You got a D.");
        }
        else
        {
            Console.WriteLine("You got an F.");
        }
        
        // Determine pass or fail
        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Keep trying!");
        }
    }
}