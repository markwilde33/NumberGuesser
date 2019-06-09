using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mark Wilde";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Aye up {0}, let's be aving you...", inputName);

            // Init correct number
            //int correctNumber = 7;

            // Create a new Random object
            Random random = new Random();

            // Init correct number
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            // Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            // Loop for user when guessing the wrong number
            while(guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Make sure its a number
                if(!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    // Tell user they did not enter a number
                    Console.WriteLine("My dear {0}!, that is not a number", inputName);

                    // Reset text color
                    Console.ResetColor();

                    // Keep going
                    continue;
                }

                // cast to int and put in th guess variable
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user they guessed wrong
                    Console.WriteLine("Wrong number {0}, have another wee go...", inputName);

                    // Reset text color
                    Console.ResetColor();
                }
            }
            // Output success message

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user they guessed correctly
            Console.WriteLine("Well done {0}!, that is correct", inputName);

            // Reset text color
            Console.ResetColor();
        }
    }
}