class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int _userScore = 0;

        string userInput = "0";

        List<Goal> listofGoals = new List<Goal>();


        while (userInput != "6")
        {
            Console.WriteLine($"You have {_userScore} points");
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goal \n3. Save Goals to a File \n4. Load Goals from a File \n5. Record an Event \n6. Quit");
            Console.Write(">");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("What type of goal would you like to create? \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                    Console.Write(">");
                    string subResponse = Console.ReadLine();
                    switch (subResponse)
                    {
                        case "1":
                            SimpleGoal simplegoal = new SimpleGoal("", "", 0, false);
                            simplegoal.CreateNewSimpleGoal();
                            listofGoals.Add(simplegoal);

                            break;

                        case "2":
                            EternalGoal eternalgoal = new EternalGoal("", "", 0, false);
                            eternalgoal.CreateNewEternalGoal();
                            listofGoals.Add(eternalgoal);
                            break;

                        case "3":
                            ChecklistGoal checklistgoal = new ChecklistGoal("", "", 0, false, 0, 0, 0);
                            checklistgoal.CreateNewChecklistGoal();
                            listofGoals.Add(checklistgoal);
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please choose 1–3.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("Your goals are: ");
                    foreach (Goal goal in listofGoals)
                    {
                        Console.WriteLine(goal.getDisplayString());
                    }
                    break;

                case "3":
                    SaveGoals(listofGoals, _userScore);
                    break;

                case "4":
                    LoadGoals(listofGoals, ref _userScore);
                    break;

                case "5":
                    Console.WriteLine("Which goal did you accomplish?");
                    for (int i = 0; i < listofGoals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {listofGoals[i].getName()}");
                    }
                    Console.Write("> ");
                    int recordChoice = int.Parse(Console.ReadLine());
                    Goal selectedGoal = listofGoals[recordChoice - 1];

                    selectedGoal.recordEvent();

                    if (selectedGoal is ChecklistGoal cgGoal)
                    {
                        _userScore += cgGoal.getPoints();
                        if (cgGoal.getisDone() && cgGoal.gettimesCompleted() == cgGoal.getTargetCount())
                        {
                            _userScore += cgGoal.getBonusPoints();
                        }
                    }
                    else
                    {
                        _userScore += selectedGoal.getPoints();
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1–6.");
                    break;
            }
        }
    }

    static void SaveGoals(List<Goal> goals, int totalPoints)
    {
        Console.WriteLine("What would you like to call your file?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.getStringForm());
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }


    static void LoadGoals(List<Goal> goals, ref int totalPoints)
{
    Console.WriteLine("What file would you like to load?");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(filename);

    // First line is total points
    totalPoints = int.Parse(lines[0]);

    // Clear the current list
    goals.Clear();

    // Each other line is a goal
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(':');
        string type = parts[0];
        string[] details = parts[1].Split(',');

        if (type == "SimpleGoal")
        {
            string name = details[0];
            string desc = details[1];
            int points = int.Parse(details[2]);
            bool isDone = bool.Parse(details[3]);

            SimpleGoal sg = new SimpleGoal(name, desc, points, isDone);
            goals.Add(sg);
        }
        else if (type == "EternalGoal")
        {
            string name = details[0];
            string desc = details[1];
            int points = int.Parse(details[2]);

            EternalGoal eg = new EternalGoal(name, desc, points, false);
            goals.Add(eg);
        }
        else if (type == "ChecklistGoal")
        {
            string name = details[0];
            string desc = details[1];
            int points = int.Parse(details[2]);
            int bonus = int.Parse(details[3]);
            int target = int.Parse(details[4]);
            int timesCompleted = int.Parse(details[5]);

            ChecklistGoal cg = new ChecklistGoal(name, desc, points, false, bonus, target, timesCompleted);
            goals.Add(cg);
        }
    }

    Console.WriteLine($"Goals loaded from {filename}. You have {totalPoints} points.");
}


    static void recordEvent()
    {
        
    }
}

