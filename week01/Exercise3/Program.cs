using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess the Number game!");
        Console.WriteLine();
        Console.WriteLine("See if you can guess the number with the least amount of guesses.");
        Console.WriteLine();
        
        //string playAgain = "yes";
        //while (playAgain == "yes")

        
        Console.Write("What is the magic number? Please enter a number between 1 and 100: ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guessNumber = 0;
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (guessNumber > magicNumber)
            {       
                Console.Write("What is your guess? ");
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.Write("What is your guess? ");
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it!");
            }
        }
        //Console.Write("Do you want to play again? Type yes or no: ");
        //playAgain = Console.ReadLin}
    }
}



// Core Requirements
// 1. Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
    // a. Ask the user for a guess.
    // b. Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
    // c. At this point, you won't have any loops.
// 2. Add a loop that keeps looping as long as the guess does not match the magic number.
    // At this point, the user should be able to keep playing until they get the correct answer.
// 3. Instead of having the user supply the magic number, generate a random number from 1 to 100.
    // Play the game and make sure it works!

//Stretch Challenge
// 1. Keep track of how many guesses the user has made and inform them of it at the end of the game.
// 2. After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".

    // //Python program I wrote in CSE 110
    // import random
    // 
    // print()
    // print("Welcome to the Guess the Number game!")
    // print("See if you can guess the number in the least amount of guesses.")
    // print()
    // 
    // play_again = "yes"
    // while play_again == "yes":
    //     random_number = random.randint(1, 101)
    // 
    //     guess_number = 0
    //     number_of_guess = 0
    //     while guess_number != random_number:
    //         guess_number = int(input("Enter your guess number: "))
    //         number_of_guess = number_of_guess + 1
    // 
    //         if guess_number > random_number:
    //             print("Lower")
    //         elif guess_number < random_number:
    //             print("Higher")
    //         else:
    //             print(f"\nYou guessed it!  The number is {guess_number}. \n\nIt took {number_of_guess} times for you to guess the number.")
    //     play_again = input("Do you want to play again? Type yes or no: ")
    // 
    // print ("Thank you for playing!")                
    // print()
    //  