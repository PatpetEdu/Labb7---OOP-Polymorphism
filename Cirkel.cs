using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public Cirkel(double radius)
        {
            Radius = radius; 
        }
        public override double Area()
        {
            Console.WriteLine("Rektangelns Area = " + Math.PI * Radius * Radius);
            return Math.PI * Radius * Radius;
        }
    }
}
