using System.ComponentModel;
using System.IO; 
public class Goals
{
    private List<Goal> _goals;

    private string _filename;

    private int _totalScore;

    //Methods--------------------------

    public Goals()
    {
        _goals = new List<Goal>();
        _filename = "Goals.txt";
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoal()
    {
        _goals.Clear();
        foreach (var line in File.ReadAllLines(_filename))
        {
            Goal goal = Goal.CreateGoalFromString(line);
            _goals.Add(goal);
        }
    }

    public void SaveGoals()
    {

        //Goes through the list of goals and writes them to my file
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }


    public void DisplayGoals()
    {

        int count = 1;
        foreach (Goal goal in _goals)
        {

            Console.Write($"{count++}: {goal.CreateDisplayString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You now have {_totalScore}");

    }

    public void RecordEvent()
    {

    }

    private void ObtainFileName(string prompt)
    {
        Console.WriteLine("What is the name of the file you wish to save to: ");
        string file = Console.ReadLine();
    }


}