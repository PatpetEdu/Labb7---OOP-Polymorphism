using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Fyrkant : Geometri
    {
        public double OneSide { get; set; }       
        public Fyrkant(double oneside)
        {
            OneSide = oneside;            
        }
        public override double Area()
        {
            Console.WriteLine("Fyrkantens Area = " + OneSide * OneSide);
            return OneSide * OneSide;
        }
    }

}

