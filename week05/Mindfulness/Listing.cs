using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        _count = 0;

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"{_prompts[promptIndex]}");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
}