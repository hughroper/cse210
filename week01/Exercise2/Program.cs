using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        string letter = "";
        float gradePlusOrMinus = gradePercentage % 10;
        string PlusOrMinus = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        if (gradePlusOrMinus >= 7)
        {
            PlusOrMinus = "+";
        }
        else if (gradePlusOrMinus <= 3)
        {
            PlusOrMinus = "-";
        }

        if (gradePercentage >= 93 || gradePercentage < 60)
        {
            Console.WriteLine($"Your grade is: {letter}");            
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{PlusOrMinus}");            
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if (gradePercentage < 70)
        {
            Console.WriteLine("Sorry, you didn't pass the class, maybe next time.");
        }


    }
}