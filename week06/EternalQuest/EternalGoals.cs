using System;



public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.Write("Enter the name of the eternal goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the eternal goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the eternal goal: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
        {
            Console.Write("Invalid input. Please enter a non-negative integer for points: ");
        }
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        Console.WriteLine($"Eternal goal '{name}' recorded with {points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()} | {GetDescription()} | {GetPoints()} | Eternal";
    }
}

