using System;

public class BreathingActivity : MindfulActivity
{
    private int _breathCount;

    public BreathingActivity(string activityName, string description, int breathCount)
        : base(activityName, description)
    {
        _breathCount = breathCount;
    }

    public int GetBreathCount()
    {
        return _breathCount;
    }

    public void SetBreathCount(int breathCount)
    {
        _breathCount = breathCount;
    }

    public void DisplayBreathingDetails()
    {
        Console.WriteLine($"Breathing Activity: {GetActivityName()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Breath Count: {_breathCount}");
    }
}