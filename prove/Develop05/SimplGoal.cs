class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points, status)
    {
        _goalType = "Simple";
    }

    public SimpleGoal(){}



    public override int RecordEvent()
    {
        SetStatus();
        return GetPoints();
    }

    public override void RunGoal()
    {
        Setname();
        SetDescription();
        SetPoints();
    }

    public override string GetStringRepresentation()
{
    return $"{base.GetStringRepresentation()}";
}

}