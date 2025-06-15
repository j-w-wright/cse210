using System;



class RunActivity : ExerciseActivity
{
    private double _distance;


    public RunActivity(DateTime date, int duration, double distance) : base(date, duration, "Run") // Call the base class constructor with duration
    {
        _distance = distance;
    }

    public override void DisplaySummary()
    {
        Console.Write($"{Date.ToShortDateString()} | Run | {_distance} miles | {Duration} minutes | Pace: {CalculatePace():0.00} min/miles");
        Console.WriteLine();
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine($"Activity: Run");
    //     Console.WriteLine($"Distance: {_distance} miles");
    //     Console.WriteLine($"Time: {Duration} minutes");
    //     Console.WriteLine($"Pace: {CalculatePace():0.00} min/miles");
    // }

    private double CalculatePace()
    {
        return Duration / _distance;
    }
}