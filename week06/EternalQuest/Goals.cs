using System;
using System.Dynamic;


public class Goals
{
    private string _shortName;
    private string _description;
    private int _points;


    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public Goals(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false; // Base class assumes goals are not complete
    }

    public string GetDetailsString()
    {
        return $"{_shortName} - {_description} (Points: {_points})";
    }

    public string GetStringRepresentation()
    { 
        return $"{_shortName}|{_description}|{_points}";
    }
}