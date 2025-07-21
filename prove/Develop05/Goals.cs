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
        Console.WriteLine("What is the name of your file? ");
        _filename = Console.ReadLine();

        foreach (var line in File.ReadAllLines(_filename))
        {
            var parts = line.Split(':');
            var type = parts[0];
            if (type == "totalscore")
            {
                _totalScore = int.Parse(parts[1]);
            }
            else
            {
                Goal goal = Goal.CreateGoalFromString(line);
                _goals.Add(goal);
            }
        }
            
    }

    public void SaveGoals()
    {

        //Goes through the list of goals and writes them to my file
        Console.WriteLine("What is the name of your file? ");
        _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"totalscore:{_totalScore}");
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
        Console.WriteLine($"You now have {_totalScore} points \n");

    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Which goal have you made progress on?");
        int choice = int.Parse(Console.ReadLine());

        _totalScore += _goals[choice - 1].RecordEvent();
    }

    private void ObtainFileName(string prompt)
    {
        Console.WriteLine("What is the name of the file you wish to save to: ");
        string file = Console.ReadLine();
    }


}