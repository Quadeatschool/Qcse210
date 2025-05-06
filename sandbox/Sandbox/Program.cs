using System;
using System.Runtime.CompilerServices;


public class Circle 
        {
            private double _radius;
            
            public void SetRadius(double radius)
            {
                if(radius < 0)
                {
                    Console.WriteLine("Error");
                    return;
                }
                _radius = radius;
            }

            public double GetRadius()
            {
                return _radius; 
            }

            public double GetArea()
            {

            }
        }


class Quade 
{

}




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


