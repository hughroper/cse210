using System;

class Program
{
    static void Main(string[] args)
    {

        string response;

        do
        {

            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.Write("\nGuess a number from 1 to 100. \n");

            while (guess != magicNumber)
            {

                Console.Write("\nWhat is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount = guessCount + 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("\nGuess higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("\nGuess lower");
                }
                else
                {
                    Console.WriteLine($"\nYou guessed it! {guess}\n");
                }
            }

            Console.WriteLine($"It took you {guessCount} attempts to guess the number.\n");

            Console.Write("Do you want to play again? (yes or no) ");
            response = Console.ReadLine();

        } while (response == "yes");

        }
}