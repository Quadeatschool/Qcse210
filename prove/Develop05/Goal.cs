using System.Globalization;

abstract public class Goal
{

    //Data
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    //Methods------------------

    protected Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
    }

    public Goal() { }

    public string GetName()
    {
        return _name; //I have it a random string return

    }


    public void Setname()
    {

    }

    public string GetDescription()
    {
        return _description;
    }


    public void SetDescription()
    {

    }

    public int GetPoints()
    {
        return _numberOfPoints;
    }

    public int SetPoints()
    {
        return _numberOfPoints;
    }

    public bool GetStatus()
    {
        return true;
    }

    public int MarkComplete()
    {
        return 1;
    }

    virtual public string GetGoal()
    {
        return "";
    }

    virtual public string ListGoal()
    {
        return "";
    }

    public override string ToString()
    {
        return "";
    }

    virtual public string GetGoalType()
    {
        return "";
    }

    abstract public int RecordEvent();

    abstract public void RunGoal();



}