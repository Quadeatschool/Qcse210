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

    public Goal(string name, string description, int points, bool status)
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
        return _status;
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
        string statusString = "[ ]";
        if (_status)
        {
            statusString = " [X]";
        }
        return $" {statusString}:{_name}|{_description}|{_numberOfPoints}\n";
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

    public virtual string GetStringRepresentation()
    {
        // Include type so you know what to create when loading
        return $"{_goalType}:{_name}|{_description}|{_numberOfPoints}|{_status}";
    }

    public static Goal CreateGoalFromString(string line)
    {
        // Example: "CheckList | Name | Desc | 10 | False | 0 | 5 | 50"
        var parts = line.Split(':');
        var type = parts[0];
        var data = parts[1].Split('|');

        switch (type)
        {
            case "Simple":
                return new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
            case "Eternal":
                return new EternalGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]), int.Parse(data[4]));
            case "CheckList":
                return new CheckListGoal(
                    data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]),
                    int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
            default:
                throw new Exception("Unknown goal type: " + type);
        }
    }

}