using System;
using System.Threading.Tasks.Dataflow;

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

        job1._jobTitle = "office slave";
        

        job1.DisplayJobInfo();

    }
}