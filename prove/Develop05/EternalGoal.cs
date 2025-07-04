using System.Reflection;

class EternalGoal : Goal
{
    private int _numberOfCompletions;

    //Methods----------------

    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _goalType = "Eternal";
    }

    public EternalGoal()
    {
    
   }

  

    public override string GetGoalType()
    {
        return "";
    }

    public override int RecordEvent()
    {
        return 1;


    }

    public override string ToString()
    {
        return "";
    }

    public override string CreateDisplayString()
    {
        return "";
    }

    public override void RunGoal()
    {
        Setname();
        SetDescription();
        SetPoints();
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{GetName()},{GetDescription()},{GetPoints()},{GetStatus()},{_numberOfCompletions}";
    }
}