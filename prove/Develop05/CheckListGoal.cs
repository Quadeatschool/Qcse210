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
    }


//    public CheckListGoal() {}



    public override void RunGoal()
    {

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

    private void ObtainMaxGoal()
    {

    }

    private void ObtainBonusPoints()
    {

    }
    

}