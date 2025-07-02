class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points, status)
    { }

    // public void SimpleGoal(){}

    public override void RunGoal()
    {

    }

    public override int RecordEvent()
    {
        return 1;
    }

    

}