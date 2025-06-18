using System;
using System.Collections.Generic;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Goal Tracker!");
        Console.WriteLine();

        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }

}
