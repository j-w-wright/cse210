using System;
using System.Collections.Generic;

class Program
{

    static List<ExerciseActivity> activities = new List<ExerciseActivity>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to The Wright Gym!  This app will help you in tracking your exercise activities during your time at the gym!");
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Exercise Tracking Menu:");
        Console.WriteLine("1. Add Exercise Activity");
        Console.WriteLine("2. View Summary");
        Console.WriteLine("3. Exit");
        Console.Write("Select an option by entering the number: ");
        string choice = Console.ReadLine();


        if (choice == "1") // AddExerciseActivity();
        {
            
            Console.Write("What activity would you like to add? (run, bike, swim): ");
            string activityType = Console.ReadLine().ToLower();
            if (activityType == "run")
            {
                Console.Write("Enter distance in miles: ");
                double distance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter duration in minutes: ");
                double duration = Convert.ToDouble(Console.ReadLine());
                RunActivity runActivity = new RunActivity(DateTime.Now, (int)duration, distance);
                activities.Add(runActivity); // Add the activity to the list
                //runActivity.DisplaySummary(); // Summary is displayed horizontally with lines inbetween each item
                //runActivity.GetSummary(); // Summary is displayed vertically with labels
                // Console.WriteLine("Press any key to continue...");
                // Console.ReadKey();
                // DisplayMenu();
            }
            else if (activityType == "bike")
            {
                Console.Write("Enter distance in miles: ");
                double distance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter duration in minutes: ");
                double duration = Convert.ToDouble(Console.ReadLine());
                BikeActivity bikeActivity = new BikeActivity(DateTime.Now, (int)duration, distance);
                activities.Add(bikeActivity); // Add the activity to the list
                // bikeActivity.DisplaySummary();
            }
            else if (activityType == "swim")
            {
                Console.Write("Enter distance in meters: ");
                double distance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter duration in minutes: ");
                double duration = Convert.ToDouble(Console.ReadLine());
                SwimActivity swimActivity = new SwimActivity(DateTime.Now, (int)duration, distance);
                activities.Add(swimActivity); // Add the activity to the list
                // swimActivity.DisplaySummary();
            }
            else
            {
                Console.WriteLine("Invalid activity type. Please try again.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            DisplayMenu();
        }
        else if (choice == "2")
        {
            foreach (ExerciseActivity activity in activities)
            {
                activity.DisplaySummary(); // Display summary for each activity 
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            DisplayMenu();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Exiting the program.");
            return; // Exit the program
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            DisplayMenu();
        }

    }
}