using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        Console.WriteLine("Welcome to the Eternal Quest Goal Tracker!");
        //Console.WriteLine($"You have {Goal.DisplayPlayerInfo()} points.");

        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please enter the number of what you'd like to do: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.WriteLine("Choice 1: Create a New Goal");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Choice 2: List Goals");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Choice 3: Save Goals");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Choice 4: Load Goals");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Choice 5: Record Event");
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for using the Eternal Quest Goal Tracker. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}