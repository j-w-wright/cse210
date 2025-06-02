using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Create an instance of Assignment
        Assignment assignment = new Assignment();
        // Create an instance of MathAssignment
        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetStudentName("Jared Wright");
        mathAssignment.SetTopic("Geometry");
        mathAssignment.SetTextbookSection("Section 5.2");
        mathAssignment.SetProblems("Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        // Create an instance of WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Jared Wright");
        writingAssignment.SetTopic("European History");
        writingAssignment.SetEssayTitle("The Rise and Fall of Empires");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingDetails());
    }
}