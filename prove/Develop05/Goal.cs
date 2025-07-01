using System.Globalization;

abstract class Goal
{

    //Data
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    //Methods------------------

    Goal(string name, string description, int points, bool status)
    {

    }

    Goal() { }

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

    // virtual public string GetGoal();

    // virtual public string ListGoal();

    public override string ToString()
    {
        return "";
    }
    



}