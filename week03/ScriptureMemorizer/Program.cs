using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Word word1 = new Word("Faith");

        // Console.WriteLine(word1.GetDisplayText());

        // word1.Hide();

        // Console.WriteLine(word1.GetDisplayText());

        Reference ref1 = new Reference("John", 3, 16);
        Console.WriteLine(ref1.GetDisplayText());
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(ref2.GetDisplayText());

    }
}