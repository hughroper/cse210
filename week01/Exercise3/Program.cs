using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("\nWhat is the magic number?");
        string magicInput = Console.ReadLine();
        int magicNumber = int.Parse(magicInput);

        Console.Write("\nWhat is your guess?");
        string guessInput = Console.ReadLine();
        int guessNumber = int.Parse(guessInput);

        if (magicNumber > guessNumber)
        {
            Console.WriteLine("\nHigher");
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("\nLower");
        }
        else
        {
            Console.WriteLine("\nYou guessed it!\n");
        }

    }
}