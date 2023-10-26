using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Parallellogram : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Parallellogram(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            Console.WriteLine("Parallellogramets Area = " + Width * Height);//metod för att räkna ut arean på ett parallellogram
            return Width * Height;
        }
    }

}
   

