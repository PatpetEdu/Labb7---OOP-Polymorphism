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
        public Ellips(double transversalAxeln, double konjugatAxeln) //konstruktor för vår ellips
        {
            TransversalAxeln = transversalAxeln; 
            KonjugatAxeln = konjugatAxeln;
        }
        public override double Area()
        {
            Console.WriteLine("Ellipsens Area = " + Math.PI * TransversalAxeln * KonjugatAxeln); //metod för att räkna ut arean på en ellips
            return Math.PI * TransversalAxeln * KonjugatAxeln;
        }
    }
}
