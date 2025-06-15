using System;


class SwimActivity : ExerciseActivity
{
    private double _distance;
    private double _numberOfLaps;

    public int Distance
    {
        get { return (int)_distance; } // Return distance as an integer
        set { _distance = value; } // Set distance as a double
    }

    public double NumberOfLaps
    {
        get { return _numberOfLaps; }
        set { _numberOfLaps = value; }
    }

    public SwimActivity(DateTime date, int duration, double distance) : base(date, duration, "Swimming")
    {
        _distance = distance;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{Date.ToShortDateString()} | Swim | {_distance} meters | {Duration} minutes | Laps: {CalculateNumberOfLaps()} laps");
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine($"Activity: {ActivityName}");
    //     Console.WriteLine($"Distance: {_distance} meters");
    //     Console.WriteLine($"Time: {Duration} minutes");
    //     Console.WriteLine($"Number of Laps: {CalculateNumberOfLaps()} laps");
    // }
    // private double CalculateSpeed()
    // {
    //     return _distance / Duration * 60; // Convert to meters per second
    // }

    // private double CalculatePace()
    // {
    //     return (Duration / (_distance / 100)); // Convert to pace per 100 meters
    // }
    
    private int CalculateNumberOfLaps()
    {
        return (int)(_distance / 50); // Pool length of 50 meters
    }
}