using System;

public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return true; // Simple goals are always complete after being recorded
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()} | {GetDescription()} | {GetPoints()} | Simple";
    }

}