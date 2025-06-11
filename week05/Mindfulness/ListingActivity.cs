using System;

public class ListingActivity : MindfulActivity
{

    private int _count;
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, int duration) 
        : base(activityName, description, duration)
    {
        _prompts = new List<string>
        { 
            "When have you felt the Holy Ghost this month?",
            "What are you grateful for?",
            "What are things that you have done to serve others this month?",
            "The names of the apostles, they could be current or past.",
            "What are things that you could do to serve others this next month?",
        };
    }

    public void Run()
    {
        GetListFromUser();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    { 
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        _count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} responses.");
    }


}