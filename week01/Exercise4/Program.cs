using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Console.WriteLine(words.Count);

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;
        string entry = "";
        int sum = 0;
        float average = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            entry = Console.ReadLine();
            number = int.Parse(entry);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int i in numbers)
        {
            // Console.Write(i);
            sum = sum + i;
        }

        average = ((float)sum) / numbers.Count;

        int largest = numbers[0];
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}