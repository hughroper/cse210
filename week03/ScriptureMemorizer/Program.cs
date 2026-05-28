using System;

class Program
{
    static void Main(string[] args)
    {

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        );
        bool quit = false;
        while (quit == false)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type quit");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWords(2);

                if (scripture.IsCompletelyHidden() == true)
                {
                    quit = true;
                }
            }

        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

    }
}