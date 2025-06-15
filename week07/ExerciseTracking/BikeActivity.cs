using System;



class BikeActivity : ExerciseActivity
{
    private double _distance; // Distance in miles

    public BikeActivity(DateTime date, int duration, double distance) : base(date, duration, "Cycling")
    {
        _distance = distance;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{Date.ToShortDateString()} | Bike | {_distance} miles | {Duration} minutes | Speed: {CalculateSpeed():0.00} miles/h");
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine($"Activity: {ActivityName}");
    //     Console.WriteLine($"Distance: {_distance} miles");
    //     Console.WriteLine($"Time: {Duration} minutes");
    //     Console.WriteLine($"Speed: {CalculateSpeed()} miles/h");
    // }
    //private double CalculatePace()
    //{
    //    return Duration / _distance; // Pace in minutes per mile    
    //}

    private double CalculateSpeed()
    {
        return (_distance / Duration) * 60; // Speed in miles per hour
    }
}