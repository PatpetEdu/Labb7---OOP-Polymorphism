using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public abstract class Geometri
    { 
        public virtual double Area()
        {
            Console.WriteLine(" Area = ");
            return 0;
        }
    }
}
