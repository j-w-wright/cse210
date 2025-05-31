using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Used for testing.
        //Reference reference = new Reference("1 Nephi", 3, 7);
        //Console.WriteLine($"{reference.GetDisplayText()}");
        Console.WriteLine();
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference.GetDisplayText(), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine($"Type out {reference.GetDisplayText()} to check your memorization.");
        string userInput = Console.ReadLine();
        if (userInput.Trim().Equals(reference.GetDisplayText(), StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Congratulations! You have successfully memorized the scripture.");
        }
        else
        {
            Console.WriteLine("Keep practicing! You can do it.");

        }
    }
}