using System;

public class ReflectionActivity : MindfulActivity
{
    public List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you learned something new about yourself.",
        "Think of a time when you overcame a challenge.",
        "THink of a time when you did something truly selfless."
    };

    public List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How did this experience affect your perspective on life?",
        "What would you do differently if you faced a similar situation again?",
        "How can you apply what you learned from this experience in the future?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    { 
        Console.WriteLine("Take a moment to consider the prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("Press Enter when you are ready to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"Now, take {_duration} seconds to think about questions related to the prompt:");
        // Display a random question
        //for (int i = 0; i < _duration; i++)
        //{
        // Console.WriteLine(GetRandomQuestion());
        // System.Threading.Thread.Sleep(5000); // Wait for 1 second before displaying the next question
        //}
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            System.Threading.Thread.Sleep(5000); // Wait for 5 seconds before displaying the next question
        }
    }

    public void Run()
    {
        DisplayPrompt();
        DisplayQuestion();
    }

}