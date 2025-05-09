public class Resume
{
    public string _name;
    public List<Job> _pastJobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Past Jobs:{_pastJobs}:");

        foreach (Job _jobTitle in _pastJobs)
        {
            _jobTitle.DisplayJobInfo();
            
        }
    }

    
}