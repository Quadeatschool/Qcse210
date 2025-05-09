using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._jobTitle = "Softwar engineer";
        job1._company = "Mcdonalds";
        job1._startYear = 0001;
        job1._endYear = 1001;

        Job job2 = new Job();

        job2._jobTitle = "office slave";
        job2._company = "Wendy's";
        job2._startYear = 1920;
        job2._endYear = 2001;

        Resume myResume = new Resume();
        myResume._name ="Quade Hafen";
        
        myResume._pastJobs.Add(job1);
        myResume._pastJobs.Add(job2);


        myResume.Display();

    }
     
}