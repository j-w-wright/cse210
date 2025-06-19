using System;

public class SimpleGoal : Goal
{


    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        base.RecordEvent();
        _isComplete = true; // Mark the goal as complete after recording the event

    }

    public override bool IsComplete()
    {
        return _isComplete; // Simple goals are always complete after being recorded
    }

    public override string GetStringRepresentation() //use this to save to a text file.
    {
        if (IsComplete() == true)
        {
            return $"[X] {GetName()} | {GetDescription()} | {GetPoints()} | Simple";
        }

        else
        {
            return $"[ ] {GetName()} | {GetDescription()} | {GetPoints()} |Simple";
        }
    }

}