using System;

public class BreathingActivity : MindfulActivity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        // Constructor for BreathingActivity
        // You can initialize any specific properties for BreathingActivity here if needed
    }
    public string Breathing()
    {
        return "Breathing";
    }

    public void Run()
    {
        // Simulate breathing exercise
        int cycleDuration = 10; // Total duration for one cycle of breathing in and out
        int totalCycles = _duration / cycleDuration;

        for (int cycle = 0; cycle < totalCycles; cycle++)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 5; i > 0; i--)
            {
                //Console.WriteLine("Breathe in...");
                Console.Write(i);
                System.Threading.Thread.Sleep(1000); // 1 second delay between the countdown numbers
                Console.Write("\b \b"); // Clear the previous number to countdown in the same space.
            }


            Console.WriteLine("Breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                System.Threading.Thread.Sleep(1000); // 1 second delay between the countdown numbers
                Console.Write("\b \b"); // Clear the previous number to countdown in the same space.
            }
        }

        int remainingTime = _duration % cycleDuration;
        if (remainingTime > 0)
        {
            int inTime = Math.Min(5, remainingTime);
            int outTime = remainingTime - inTime;
            if (inTime > 0)
            {
                Console.WriteLine("Breathe in...");
                for (int i = inTime; i > 0; i--)
                {
                    Console.Write(i);
                    System.Threading.Thread.Sleep(1000); // 1 second delay between the countdown numbers
                    Console.Write("\b \b"); // Clear the previous number to countdown in the same space.
                }
            }
            if (outTime > 0)
            {
                Console.WriteLine("Breathe out...");
                for (int i = outTime; i > 0; i--)
                {
                    Console.Write(i);
                    System.Threading.Thread.Sleep(1000); // 1 second delay between the countdown numbers
                    Console.Write("\b \b"); // Clear the previous number to countdown in the same space.
                }
            }
        }
    }
}