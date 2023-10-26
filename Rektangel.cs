using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Rektangel : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rektangel(double width, double height)
        {
            Width = width;
            Height = height;
            //Width = 10;
            //Height = 5;
        }
        public override double Area()
        {
            Console.WriteLine("Rektangelns Area = " + Width * Height);
            return Width * Height;
        }
    }
 
}
