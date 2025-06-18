using System;

public class ChecklistGoals : Goal
{ 
    private int _targetCount;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoals(string name, string description, int points, int targetCount, int _bonus) : base(name, description, points)
    {
        _targetCount = targetCount;
        _amountCompleted = 0;
        _bonus = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _targetCount)
        {
            _amountCompleted++;
        }
        else if (IsComplete())
        {
            return;
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"[ ] Goal: {GetName()} - {GetDescription()} {_amountCompleted}/{_targetCount}";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetName()} | {GetDescription()} | {GetPoints()} | {_amountCompleted}/{_targetCount} | Checklist | ";
    }
}