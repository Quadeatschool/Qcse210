// using System;
// using System.Diagnostics.Tracing;
// using System.IO.Compression;


// class Program
// {
//     static void Main(string[] args)
//     {
//         Circle myCircle = new Circle(10);
//         // myCircle.SetRadius(10);
//         Console.WriteLine($"{myCircle.GetRadius()}");
//         // Circle myCircle2 = new Circle();
//         // myCircle2.SetRadius(20);
//         // Console.WriteLine($"{myCircle2.GetRadius()}");

//         // Console.WriteLine($"{myCircle.GetArea()}");
//         // Console.WriteLine($"{myCircle2.GetArea()}");

//         // Cylinder myCylinder = new Cylinder();
//         // myCylinder.SetHeight(10);
//         // myCylinder.SetCircle(myCircle);
//         // Console.WriteLine($"{myCylinder.GetVolume()}");
//     }
// }
 

// // public Circle()
// // {
// //     int _radius;
// // }


// class Circle
// {
//     private double _radius;

//     public void SetRadius(double radius)
//     {
//         if (radius < 0)
//         {
//             Console.WriteLine("Error, radius must > 0");
//             return;
//         }
//         _radius = radius;
//     }

//     public double GetRadius()
//     {
//         return _radius;
//     }

//     public double GetArea()
//     {
//         return Math.PI * _radius * _radius;
//     }
// }
 

