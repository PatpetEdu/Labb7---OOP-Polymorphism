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
        public Fyrkant(double oneside) //konstruktor för vår fyrkant
        {
            OneSide = oneside;       
        }
        public override double Area()
        {
            Console.WriteLine("Fyrkantens Area = " + OneSide * OneSide); //metod för att räkna ut arean på en fyrkant
            return OneSide * OneSide;
        }
    }

}

