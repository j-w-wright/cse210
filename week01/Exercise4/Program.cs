using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        int number; // Variable to store the current number, don't need to have it initialized to 0

        // A do-while loop to get the numbers from the user
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } 
        while (number != 0);

        // Check if the list is empty
        if (numbers.Count > 0)
        {
            // Compute the sum of the numbers in the list
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            
            // Compute the average of the numbers in the list
            float average = (float)sum / numbers.Count;

            // Find the largest number in the list
            int largestNumber = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > largestNumber)
                {
                    largestNumber = num;
                }
            }
            // Display the results
            Console.WriteLine($"The sum of the list of numbers is: {sum}");
            Console.WriteLine($"The average of the list of numbers is: {average}");
            Console.WriteLine($"The largest number is: {largestNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.  Please enter numbers greater than 0.");
        }
    }
}


// Core Requirements
// 1. Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

// 2. Compute the sum, or total, of the numbers in the list.

// 3, Compute the average of the numbers in the list.

// 4. Find the maximum, or largest, number in the list.

// Stretch Challenge
// 1. Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).

// 2. Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.