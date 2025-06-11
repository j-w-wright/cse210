using System;


public class MindfulActivity
{
    private string _activityName;
    private string _description;
    public int _duration; // in seconds

    public MindfulActivity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName()
    {
        return _activityName;
    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        ShowSpinner(1);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\"); // need to backslashes to override the escape character

       
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            System.Threading.Thread.Sleep(100); // Delay for 0.5 second
            Console.Write("\b \b"); // Clear the previous character

            i++;

            if (i >= spinnerAnimation.Count)
            {
                i = 0; // Reset the index to loop through the spinner animation
            }
        }
    }

    public void ShowCountDown(int seconds)
    { 
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second
        }
    }
}
