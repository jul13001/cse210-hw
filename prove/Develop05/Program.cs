using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choice = Console.ReadLine();

            GoalManager _goalmanager = new GoalManager();
            if (choice == "6")
            {
                break;
            }

            if (choice == "1")
            {
                _goalmanager.CreateGoal();
            }
            if(choice == "2")
            {
                _goalmanager.ListGoalDetails();
            }
            if (choice == "3")
            {
                _goalmanager.SaveGoals();
            }
            if (choice == "4")
            {
                _goalmanager.LoadGoals();
            }
            if (choice == "5")
            {
                _goalmanager.RecordEvent();
            }
        }
    }
}