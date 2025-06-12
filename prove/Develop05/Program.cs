using System;
using System.Runtime.CompilerServices;

// using System.Runtime.CompilerServices;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int sleepTime = 250;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(20);

        string animationString = "(^_^) (-_-)";

        string animationString2 = "-+\\/-|/";
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            // % in this case keeps the loop going 0-4
            Thread.Sleep(sleepTime);
            Console.Write("\b");

            // if two digit time then add an if with another \b
        }

        int time = 9;
        int count = time;

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");

            // if two digit time then add an if with another \b
        }


        while (DateTime.Now < endTime)
        {

            Console.Write(animationString[0..5]);
            Thread.Sleep(500);
            Console.WriteLine(" . ");
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animationString);
            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }
}