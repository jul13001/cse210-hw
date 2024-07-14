using System;

class Program
{
    static void Main(string[] args)
    {   
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                break;
            }
            // Prompt for duration if the user did not choose to quit

            Console.Write("Enter the duration for the activity in seconds: ");
            string durationInput = Console.ReadLine();
            int duration = int.Parse(durationInput);

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            DateTime currentTime = DateTime.Now;
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly", duration);
                breathingActivity.DisplayStartingMessage();
                if (currentTime < futureTime)
                    breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration);
                reflectingActivity.DisplayStartingMessage();
                if (currentTime < futureTime)
                    reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                listingActivity.DisplayStartingMessage();
                if (currentTime < futureTime)
                    listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }
    }
}
