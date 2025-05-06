using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirment 1
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.WriteLine("You earned an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You earned a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You earned a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You earned a D.");
        }
        else
        {
            Console.WriteLine("You earned an F.");
        }
        // Core Requirement 2
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class, but you can!  Please try again.");
        }

        // Core Requirement 3
        // I left core requirements 1 and 2 in so that I can see the two different ways of doing this code.
        Console.Write("Enter your grade percentage: ");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter = ""; 

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        {
            Console.WriteLine($"You earned a {letter}.");
        }
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class, but you can!  Please try again.");
        }
    }
}