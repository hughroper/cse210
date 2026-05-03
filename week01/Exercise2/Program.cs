using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("\nEnter your grade percentage: ");
        string inputValue = Console.ReadLine();
        float gradePercent = float.Parse(inputValue);
        string letter = "";


        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"\nYour grade is a {letter}.\n");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations you passed the course.\n");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass, better luck next time.\n");
        }



    }
}