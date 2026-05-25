using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Word word1 = new Word("Faith");

        Console.WriteLine(word1.GetDisplayText());

        word1.Hide();

        Console.WriteLine(word1.GetDisplayText());

    }
}