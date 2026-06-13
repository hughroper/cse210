using System.IO;

public class GoalManager
{



    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            Console.WriteLine();

        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. One-Time Goal");
        Console.WriteLine(" 2. Recurring Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.WriteLine("What type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            OneTimeGoal goal = new OneTimeGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "2")
        {
            RecurringGoal goal = new RecurringGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal goal = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }


    }

    private void ListGoals()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            int goalNumber = i + 1;

            Goal goal = _goals[i];

            Console.WriteLine($"{goalNumber}. {goal.GetDetailsString()}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("what is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        Console.WriteLine($"Loaded score: {_score}");

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(':');

            string[] goalData = parts[1].Split(',');

            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);

            if (parts[0] == "OneTimeGoal")
            {
                bool isComplete = bool.Parse(goalData[3]);

                OneTimeGoal goal = new OneTimeGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (parts[0] == "RecurringGoal")
            {
                RecurringGoal goal = new RecurringGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (parts[0] == "CheckListGoal")
            {
                int amountCompleted = int.Parse(goalData[3]);
                int target = int.Parse(goalData[4]);
                int bonus = int.Parse(goalData[5]);

                CheckListGoal goal = new CheckListGoal(name, description, points, amountCompleted, target, bonus);
                _goals.Add(goal);
            }

        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            int goalNumber = i + 1;

            Goal goal = _goals[i];

            Console.WriteLine($"{goalNumber}. {goal.GetDetailsString()}");
        }

        Console.WriteLine("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        int index = choice - 1;
        Goal selectedGoal = _goals[index];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("That goal is already complete.");
        }
        else
        {
            selectedGoal.RecordEvent();

            int pointsEarned = selectedGoal.GetPoints();

            if (selectedGoal.IsComplete())
            {
                pointsEarned += selectedGoal.GetBonusPoints();
            }

            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You earned {pointsEarned} points.");
            Console.WriteLine($"You now have {_score} points.");
        }

    }


}