using System;

class ChecklistGoals : Goal
{ 
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoals(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetName()} | {GetDescription()} | {GetPoints()} | Checklist | {_currentCount}/{_targetCount}";
    }
}