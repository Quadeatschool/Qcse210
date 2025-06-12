using System;
using System.Runtime.CompilerServices;




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ni hou");

        
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine();
        Console.WriteLine($"{myCircle.GetRadius()}");

    }

}


