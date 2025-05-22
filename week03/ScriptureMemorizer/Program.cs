using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine("Enter the scripture book name:");
        string book = Console.ReadLine();
        Console.WriteLine("Enter the chapter number:");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of verses:");
        int verse = int.Parse(Console.ReadLine());
            if (verse == 1)
            {
                Console.WriteLine("Enter the verse number:");
                int verseNumber = int.Parse(Console.ReadLine());
                return;
            }
            elif (verse > 1)
            {
                Console.WriteLine("Enter the verse numbers (comma separated):");
                string[] verseNumbers = Console.ReadLine().Split(',');
                foreach (string number in verseNumbers)
                {
                    int verseNumber = int.Parse(number.Trim());
                    // Process each verse number
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of verses.");
            }
        Console.WriteLine("Enter the scripture text:");
        string text = Console.ReadLine();
    }
}