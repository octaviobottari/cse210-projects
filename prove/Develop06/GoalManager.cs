public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(string goalType, string shortName, string description, string points, int target = 0, int bonus = 0)
    {
        Goal goal = null;
        switch (goalType.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            if (_goals[goalIndex].IsComplete())
            {
                var pointsString = _goals[goalIndex].GetStringRepresentation().Split('-')[1].Trim().Split(' ')[0];
                if (int.TryParse(pointsString, out int points))
                {
                    _score += points;
                }
                else
                {
                    Console.WriteLine("Error: Points not in correct format.");
                }
            }
        }
    }

    public void SaveGoals()
    {
    }

    public void LoadGoals()
    {
    }
}
