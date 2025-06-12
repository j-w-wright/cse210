using System;



public class EternalGoals : Goals
{
    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
    
    public string GetStringRepresentation()
    { 
        return $"{GetShortName()} - {GetDescription()} (Points: {GetPoints()}) [Eternal Goal]";
    }
}

