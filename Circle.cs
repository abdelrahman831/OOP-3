using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Circle : ICircle
    {
        public double Area { get; set; }
        public double r;


        public Circle(double r) 
        {
            this.r = r;
            this.Area = r*r*Math.PI;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"{Area}");

        }

    }
}
