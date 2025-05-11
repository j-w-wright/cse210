using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!  This is the abstraction activity.");
        Job job1 = new Job();
        job1._JobTitle = "Software Engineer";
        job1._Company = "Apple";
        job1._StartYear = 2006;
        job1._EndYear = 2025;
        job1._DisplayJobDetails = $"{job1._JobTitle} ({job1._Company}) {job1._StartYear}-{job1._EndYear}"; 

        Console.WriteLine($"{job1._DisplayJobDetails}");

        Job job2 = new Job();
        job2._JobTitle = "Software Engineer";
        job2._Company = "Google";
        job2._StartYear = 2016;
        job2._EndYear = 2025;
        job2._DisplayJobDetails = $"{job2._JobTitle} ({job2._Company}) {job2._StartYear}-{job2._EndYear}";

        Console.WriteLine($"{job2._DisplayJobDetails}");
    }
}