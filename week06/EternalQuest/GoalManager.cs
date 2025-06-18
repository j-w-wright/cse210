using System;
using System.Collections.Generic;
using System.Security.Cryptography;


public class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    public void Start() //This is the main function for this class.
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?  (Enter the number) ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals("goals.txt");
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Hope you return soon!  Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.  Please select a number from 1 to 6.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo() // Displays the players' current score
    {
        Console.WriteLine($"You currently have {_score} points.");
    }

    public void ListGoalNames() // Lists the names of each of the goals
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails() // List the details of each goal (including the checkbox of whether it is complete)
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal() // Asks the user for the information about a new goal.  Then creates the goal and adds it to the list
    {
        Console.WriteLine("You are creating a new goal.");
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please enter the number of the type of goal you want to create: ");
        int goalType;
        if (!int.TryParse(Console.ReadLine(), out goalType))
        {
            Console.WriteLine("Invalid input.");
        }

        Console.Write("Enter the name of the goal: ");
        string _name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string _description = Console.ReadLine();
        Console.Write("Enter how many points the goal is worth: ");
        int _points;
        if (!int.TryParse(Console.ReadLine(), out _points))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        _goals.Add(new Goal(_name, _description, _points));
        Console.WriteLine("Goal has been created!");
    }

    public void RecordEvent() // Asks the user which goal they have done and then records the event by calling the RecordEvent() method on that goal
    {
        Console.WriteLine("Choice 2: Record Event");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }
        ListGoalNames();
        Console.Write("Which goal did you complete?  Enter the number: ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= _goals.Count)
        {
            Goal goal = _goals[index - 1];
            goal.RecordEvent();
            _score += goal.GetPoints();
            Console.WriteLine($"You have earned {goal.GetPoints()} points!  Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals() // Saves the list of goals in a file (goals.txt)
    {
        Console.WriteLine("Choice 3: Save Goals");
        string filename = "goals.txt";
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine($"Goals saved to {filename}.");
    }

    public void LoadGoals(string file) // Loads the list of goals from a file (goals.txt)
    {
        Console.WriteLine("Choice 4: Load Goals");

        if (!File.Exists(file))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 3)
            {
                string name = parts[0].Trim();
                string description = parts[1].Trim();
                int points;
                if (int.TryParse(parts[2].Trim(), out points))
                {
                    _goals.Add(new Goal(name, description, points));
                }
                else
                {
                    Console.WriteLine($"Invalid points value in line: {line}");
                }
            }
        }
        Console.WriteLine("Your goals have been loaded.");
    }
}