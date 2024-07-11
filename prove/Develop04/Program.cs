using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        int userChoice = 0;
        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();
            userChoice = int.Parse(choice);

            if (userChoice == 1)
            {
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                reflectingActivity.Run();
            }
            else if (userChoice == 3);
            {
                listingActivity.Run();
            }
            else if(userChoice == 4)
            {
                break;
            }
            else if( userChoice > 4)
            {
                return $"That is an invalid option, try again.";
            }
        }
    }
}