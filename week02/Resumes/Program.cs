using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!  This is the abstraction activity.");

        Job job1 = new Job();
        job1._JobTitle = "Software Engineer";
        job1._Company = "Apple";
        job1._StartYear = 2006;
        job1._EndYear = 2025;
        // The below line was moved to the Display method in the Job class.

            //job1._DisplayJobDetails = $"{job1._JobTitle} ({job1._Company}) {job1._StartYear}-{job1._EndYear}";

        //Console.WriteLine($"{job1._DisplayJobDetails}");

        Job job2 = new Job();
        job2._JobTitle = "Software Engineer";
        job2._Company = "Google";
        job2._StartYear = 2016;
        job2._EndYear = 2025;
        // The below line was moved to the Display method in the Job class.
             //job1._DisplayJobDetails = $"{job1._JobTitle} ({job1._Company}) {job1._StartYear}-{job1._EndYear}"; 

        //Console.WriteLine($"{job2._DisplayJobDetails}");

        Resume resume = new Resume();
        resume._FirstName = "Ned";
        resume._LastName = "Schnebley";

        resume._Jobs.Add(job1);
        resume._Jobs.Add(job2);


        //Console.WriteLine($"{resume._Jobs[0]._JobTitle}");

        resume.Display();
        // The below code was moved to the Display method in the Resume class.

            //Console.WriteLine($"Name: {resume._FirstName} {resume._LastName}");
            //Console.WriteLine($"Jobs: ");
            //Console.WriteLine($"{resume._Jobs[0]._DisplayJobDetails}");
            //Console.WriteLine($"{resume._Jobs[1]._DisplayJobDetails}");
    }
}