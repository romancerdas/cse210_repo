class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string userInput = "0";
        



        while (userInput != "5")
        {
            Console.WriteLine($"You have {_userScore} points");
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goal \n3. Save Goals to a File \n4. Load Goals from a File \n5. Record an Event \n6. Quit");
            Console.Write(">");

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("What type of goal would you like to create? \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                    Console.Write(">");
                    string subResponse = Console.ReadLine();
                    switch (subResponse)
                    {
                        case "1":
                            SimpleGoal simplegoal = new SimpleGoal("", "", 0, "", false);
                            simplegoal.CreateNewSimpleGoal();
                            break;

                        case "2":
                            EternalGoal eternalgoal = new EternalGoal("", "", 0, "", false);
                            eternalgoal.CreateNewEternalGoal();
                            break;

                        case "3":
                            ChecklistGoal checklistgoal = new ChecklistGoal("", "", 0, "", false, 0, 0, 0);
                            checklistgoal.CreatNewChecklistGoal();
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please choose 1–3.");
                            break;
                    }
                    break;

                case "2":
                    // DisplayGoals();
                    break;

                case "3":
                    // SaveGoals();
                    break;

                case "4":
                    // LoadGoals();
                    break;

                case "5":
                    // RecordEvent();
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
}