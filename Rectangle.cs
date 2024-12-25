using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Rectangle : IRectangle
    {

        public double Area { get; set; }
        double b { get; set; }
        double h { get; set; }


        public Rectangle(double b, double h)
        {
            this.b = b;
            this.h = h;
            this.Area = b * h;
            
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"{Area}");
        }

    }
}
