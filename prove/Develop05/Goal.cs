using System.Globalization;

abstract public class Goal
{

    //Data
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    protected string _goalType;

    //Methods------------------

    protected Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
    }

    public Goal() { }

// Properties------------------
    public string GetName()
    {
        return _name; //I have it a random string return

    }


    public void Setname()
    {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();
    }

//------------------
    public string GetDescription()
    {
        return _description;
    }


    public void SetDescription()
    {
        Console.Write("Enter a description of the goal: ");
        _description = Console.ReadLine();
    }

//------------------
    public int GetPoints()
    {
        return _numberOfPoints;
    }

    public void SetPoints()
    {
        Console.Write("Enter the number of points for the goal: ");
        string input = Console.ReadLine();
        int points;
        while (!int.TryParse(input, out points) || points < 0)
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        _numberOfPoints = points;
    }

//------------------
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
        return _goalType;
    }

    virtual public string CreateDisplayString()
    {
        return $"Your Goals are: \n {_name}: \n {_description} \n\n Your score : {_numberOfPoints} points";
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