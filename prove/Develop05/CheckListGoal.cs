class CheckListGoal : Goal
{
    private int _numberOfCompletions;

    private int _maxGoals;

    private int _bonusPoints;


    //-----------------------------------

    public CheckListGoal(string name, string description, int points, bool status, int completions, int max, int bonus) : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
        _goalType = "CheckList";
    }


    //    public CheckListGoal() {}





    public override int RecordEvent()
    {
        return 1;
    }

    public override string ToString()
    {
        return "";
    }

    public override string ListGoal()
    {
        return "";
    }

    private void GetMaxGoal()
    {
        Console.Write("Enter the maximum number of goals for this checklist: ");
        string input = Console.ReadLine();
        int maxGoals;
        while (!int.TryParse(input, out maxGoals) || maxGoals < 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        _maxGoals = maxGoals;
    }


    private void ObtainBonusPoints()
    {
        Console.WriteLine("Enter the bonus bounty for completing this goal the maximum number of times: ");
        string input = Console.ReadLine();
        int bonusPoints;
        while (!int.TryParse(input, out bonusPoints) || bonusPoints < 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        _bonusPoints = bonusPoints;
    }
    

    public override void RunGoal()
    {
        Setname();
        SetDescription();
        SetPoints();
        ObtainBonusPoints();
        GetMaxGoal();
    }
}