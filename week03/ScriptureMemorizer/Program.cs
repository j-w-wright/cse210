using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("1 Nephi", 3, 7);
        Console.WriteLine($"{reference.GetDisplayText()}");
    }
}