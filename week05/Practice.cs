using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is my practice program.");
        Student student = new Student();
        string name = student.GetName();
        Console.WriteLine("Name: " + name);
    }

}

public class Person
{
    public string GetName()
    {
        return "Jared";
    }
}

public class Student : Person
{
    public string GetNumber()
    {
        return "123456789";
    }
}
