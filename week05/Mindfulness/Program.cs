using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "";

        while (choice != "4")
        {

            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (choice == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
            }

            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.Run();
            }

        }

    }
}
