// I didn't add next creative things. 

using System;

class Program
{
    static void Main(string[] args)
    {

        // stuff goes here

        // Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGen promptGen = new PromptGen();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");

                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");

                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
        }

    }
}