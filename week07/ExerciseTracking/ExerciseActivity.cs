using System;
using System.Collections.Generic;


class ExerciseActivity
{
    private DateTime date; // date of the activity
    private int _duration; // activity length in minutes
    private string _activityName; // name of the activity


    public ExerciseActivity(DateTime date, int duration, string activityName)
    {
        this.date = date;
        this._duration = duration;
        this._activityName = activityName;
    }
    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
    public string ActivityName
    {
        get { return _activityName; }
        set { _activityName = value; }
    }

    public virtual void DisplaySummary()
    {
        Console.WriteLine($"Activity Name: {_activityName}");
        Console.WriteLine($"Activity Date: {date}");
        Console.WriteLine($"Duration: {_duration} minutes");
    }
    //public virtual void GetSummary()
    //{
    //  Console.WriteLine($"Activity Date: {date}");
    //  Console.WriteLine($"Duration: {duration} minutes");
    //}

}