using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
    }


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine(_goals.Count());
        int i = 1;
        foreach (Goal goal in _goals)
        {
            goal.Display(i);
            i += 1;
            //.WriteLine(goal.GetName());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        var typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                Console.Write("Enter goal name: ");
                string sName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string sDescription = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int sPoints = int.Parse(Console.ReadLine());
                SimpleGoal newGoal = new SimpleGoal(sName, sDescription, sPoints);
                _goals.Add(newGoal);
            return;
            case "2":
                Console.Write("Enter goal name: ");
                string eName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string eDescription = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int ePoints = int.Parse(Console.ReadLine());
                EternalGoal newEternalgoal = new EternalGoal(eName, eDescription, ePoints);
                _goals.Add(newEternalgoal);
            return;
            case "3":
                Console.Write("Enter goal name: ");
                string cName = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string cDescription = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int cPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished to earn a bonus?");
                int cTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing this task?");
                int cBonus = int.Parse(Console.ReadLine());
                CheckListGoal newChecklistgoal = new CheckListGoal(cName, cDescription, cPoints, cTimes, cBonus);
                _goals.Add(newChecklistgoal);
            return;

        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string goals = goal.GetDetailsString();
            Console.WriteLine(goals);
            Console.WriteLine("Anything Test of ListGoal Details");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].GetDetailsString()}");
        }

        Console.WriteLine("Which goal did you complete?");
        int completedGoalIndex = int.Parse(Console.ReadLine());

        if (completedGoalIndex >= 0 && completedGoalIndex < _goals.Count)
        {
            Goal completedGoal = _goals[completedGoalIndex];
            _score += completedGoal._points;
            Console.WriteLine($"You have earned {completedGoal._points} points. Total score: {_score}");
        }

    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score); 
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
    }
        
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load the file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);


    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

    }
    }
     
}