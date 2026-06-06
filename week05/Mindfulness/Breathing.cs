public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Now Breathe out...");
            ShowCountdown(6);
        }

        DisplayEndingMessage();
    }


}