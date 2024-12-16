using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.CreateGoal("simple", "Run a Marathon", "Complete a marathon", "1000");
        goalManager.CreateGoal("eternal", "Read Scriptures", "Read scriptures daily", "0");
        goalManager.CreateGoal("checklist", "Attend the Temple", "Attend the temple 10 times", "50", 10, 10);

        bool running = true;
        while (running)
        {
            Console.Clear();
            goalManager.DisplayPlayerInfo();
            goalManager.ListGoalNames();

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Record an event for a goal");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the index of the goal you want to update (0-based index):");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        goalManager.RecordEvent(goalIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter goal type (simple, eternal, checklist):");
                    string goalType = Console.ReadLine();
                    Console.WriteLine("Enter goal name:");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Enter goal description:");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("Enter goal points:");
                    string goalPoints = Console.ReadLine();

                    int target = 0, bonus = 0;
                    if (goalType.ToLower() == "checklist")
                    {
                        Console.WriteLine("Enter target (times to complete):");
                        target = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter bonus points for completion:");
                        bonus = int.Parse(Console.ReadLine());
                    }

                    goalManager.CreateGoal(goalType, goalName, goalDescription, goalPoints, target, bonus);
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}


// ChatGPT's Influence: ChatGPT helped me understand how to track progress for checklist goals by implementing the TimesCompleted and Target properties. It also guided me in overriding GetStringRepresentation() to display the current progress and suggested a method like RecordProgress() to increment the completion count. This ensured that checklist goals could be tracked incrementally and awarded points when completed.

