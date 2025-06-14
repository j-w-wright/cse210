using System;
using System.Dynamic;


public class Goal
{
    private string _name;
    private string _description;
    private int _points;


    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.Write("Enter the name of the goal: ");
        string _name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string _description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int _points;
        while (!int.TryParse(Console.ReadLine(), out _points) || _points < 0)
        {
            Console.Write("Invalid input. Please enter a non-negative integer for points: ");
        }
        SetName(_name);
        SetDescription(_description);
        SetPoints(_points);
        Console.WriteLine($"Goal '{_name}' recorded with {_points} points.");
    }

    public virtual bool IsComplete()
    {
        return false; // Base class assumes goals are not complete
    }

    public string GetDetailsString()
    {
        return $"{_name} - {_description} (Points: {_points})";
    }

    public virtual string GetStringRepresentation()
    { 
        return $"{_name}|{_description}|{_points}";
    }
}