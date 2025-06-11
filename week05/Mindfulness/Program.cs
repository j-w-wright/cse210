using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine();

        int choice = 0;
        while (choice != 4)
        {    // User selects a mindfulness activity from a menu.
            Console.WriteLine("Mindfulness Activity Options: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write($"{userName}, begin an activity by entering the number: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax and focus on your breathing.", 0);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();

            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on your thoughts and feelings.", 0);
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.Run();
                reflectionActivity.DisplayEndingMessage();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "For this activity you will list things that relate to a given prompt.", 0);
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for participating in the Mindfulness activities.  Hope you return soon!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }    
    }
}