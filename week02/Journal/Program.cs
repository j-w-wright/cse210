using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

// Functional Requirements
// This program must contain the following features:

// 1. Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// 2. Display the journal - Iterate through all entries in the journal and display them to the screen.
// 3. Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// 4. Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
// 5. Provide a menu that allows the user choose these options
// 6. Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?

// Design Requirements
// In addition, your program must:

// 1. Contain classes for the major components in the program. (Each class should be in its own file where the filename matches the class name.)
// 2. Contain at least two classes in addition to the Program class.
// 3. Demonstrate the principle of abstraction by using member variables and methods appropriately.

class Program
{
    static void Main(string[] args)
    {
        //Get the user's name
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Hi {name}! Welcome to your Journal.");
        Console.WriteLine();

        // Create a new instance of Journal
        Journal journal = new Journal();
        // Get the user's choice
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal entries");
            Console.WriteLine("3. Save the journal entry to a file");
            Console.WriteLine("4. Load the journal entry from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter your choice (1-5): ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                // Create a new instance of Entry
                Entry newEntry = new Entry();
                journal.AddEntry(newEntry);
                // Display the entry
                newEntry.Display();
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                // Display all entries
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save the entries to the file
                Console.Write("Enter the filename to save the journal entry: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                // Load the journal entry from a file
                Console.Write("Enter the filename to load the journal entry: ");
                string file = Console.ReadLine();
                // Load the entries from the file
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                // Quit the program
                Console.WriteLine("Goodbye! Come back to write some more soon.");
                break;
            }
        }
    }
}