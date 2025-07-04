class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points, status)
    {
        _goalType = "Simple";
    }

    public SimpleGoal(){}

    

    public override int RecordEvent()
    {
        return 1;
    }

    public override void RunGoal()
    {
        Setname();
        SetDescription();
        SetPoints();
    }

    public override string GetStringRepresentation()
{
    return $"{_goalType}:{GetName()},{GetDescription()},{GetPoints()},{GetStatus()}";
}

}