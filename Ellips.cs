using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Ellips : Geometri
    {
        public double TransversalAxeln { get; set; }
        public double KonjugatAxeln { get; set; }
        public Ellips(double transversalAxeln, double konjugatAxeln)
        {
            TransversalAxeln = transversalAxeln;
            KonjugatAxeln = konjugatAxeln;
        }
        public override double Area()
        {
            Console.WriteLine("Ellipsens Area = " + Math.PI * TransversalAxeln * KonjugatAxeln);
            return Math.PI * TransversalAxeln * KonjugatAxeln;
        }
    }
}
