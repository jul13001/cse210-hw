using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the number?");
        string number = Console.ReadLine();
        int magic_number = int.Parse(number);
        
        int user_guess = 0;
        while (user_guess != magic_number)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            user_guess = int.Parse(guess);
            
            if (user_guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (user_guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
        }
        
        Console.WriteLine("You got it right!");
    }
}
