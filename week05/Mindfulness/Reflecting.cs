public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you get started?",
            "How did you feel when it was complete?"
        };

    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"{_prompts[promptIndex]}");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine(_questions[questionIndex]);

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

}