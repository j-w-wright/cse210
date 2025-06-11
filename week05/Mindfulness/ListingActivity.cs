using System.IO;

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
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        _count = 0;
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} responses.");

        // Save prompt and list of responses to a file.
        string fileName = "ListingActivityResponses.txt";
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine($"Prompt: {prompt}");
                writer.WriteLine("Responses:");
                for (int i = 0; i < responses.Count; i++)
                {
                    writer.WriteLine($"Response {i + 1}: {responses[i]}");
                }
                writer.WriteLine("-----");
            }
        }
    }
}