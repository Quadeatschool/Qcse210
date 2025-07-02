using System.Reflection;

class EternalGoal : Goal
{
    private int _numberOfCompletions;

    //Methods----------------

    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
    }

    public EternalGoal()
    {
    
   }

    public override void RunGoal()
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

    public override string ListGoal()
    {
        return "";
    }


}