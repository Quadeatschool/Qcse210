using System.ComponentModel;

public class Goals
{
    private List<Goal> _goals;

    private string _filename;

    private int _totalScore;

    //Methods--------------------------

    public Goals()
    {
        _goals = new List<Goal>();
        _filename = "goals.txt";
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoal()
    {

    }

    public void SaveGoals()
    {

    }


    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {

            Console.Write($"{goal.CreateDisplayString()}");
        }
    }

    public void DisplayScore()
    {

    }




}