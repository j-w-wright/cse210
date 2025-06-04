using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine("Mindfulness is the practice of being present and fully engaged in the moment, without judgment. It can help reduce stress, improve focus, and enhance overall well-being.");
        // User selects a mindfulness activity from a menu.
        Console.WriteLine("Mindfulness Activities Available: ");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.Write("Which mindfulness activity would you like to do? Please enter the number: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        // Display the user's choice for testing
        Console.WriteLine("You selected: " + choice);
        
        /* if (choice == 1)
        {
            // Breathing activity
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Start();
        }
        else if (choice == 2)
        {
            // Reflection activity
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.Start();
        }
        else if (choice == 3)
        {
            // Listing activity
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Start();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid activity.");
        }
        */

    }
}