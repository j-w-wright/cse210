using System;

public class ReflectionActivity : MindfulActivity
{
    private string _reflectionPrompt;

    public ReflectionActivity(string activityName, string description, string reflectionPrompt)
        : base(activityName, description)
    {
        _reflectionPrompt = reflectionPrompt;
    }

    public string GetReflectionPrompt()
    {
        return _reflectionPrompt;
    }

    public void DisplayReflectionDetails()
    {
        Console.WriteLine($"Reflection Prompt: {_reflectionPrompt}");
    }
}