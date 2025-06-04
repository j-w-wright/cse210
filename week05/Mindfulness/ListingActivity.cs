using System;

public class ListingActivity : MindfulActivity
{
    private string _activityName;
    private string _description;
    private int _numberOfItems;

    public ListingActivity(string activityName, string description, int numberOfItems)
        : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
        _numberOfItems = numberOfItems;
    }

    public void DisplayListingDetails()
    {
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Number of items to list: {_numberOfItems}");
    }
}