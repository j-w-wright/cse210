using System;

public class MindfulActivity
{
    private string _activityName;
    private string _description;

    public MindfulActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void DisplayActivityDetails()
    {
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Description: {_description}");
    }
}