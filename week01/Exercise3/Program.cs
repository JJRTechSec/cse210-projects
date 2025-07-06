using System;

class Program
{
    static void Main(string[] args)
    {
        // ASK USER FOR MAGIC NUMBER
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        int numberOfGuesses = 0;

        while (guess != number)
        {
            Console.Write("Guess a number from 1-100: ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Would you like to play again? ");
                Console.ReadLine();
                string response = Console.ReadLine();
            }

            numberOfGuesses++;
            Console.WriteLine($"Number of guesses: {numberOfGuesses}");
        }


            // IF STATEMENT TO DETERMINE IF HIGHER OR LOWER

            // ADD LOOP TO KEEP USER GUESSING UNTIL CORRECT

            // GO BACK AND GENERATE RANDOM NUMBER 1-100

            // KEEP TRACK OF NUMBER OF GUESSES

            // ASK USER IF THEY WANT TO PLAY AGAIN
        }
}