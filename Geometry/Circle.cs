using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle:Figure
    {
        double radius;
        public Circle(double radius)
        {
            if (radius >= 0)
                this.radius = radius;
            else
                throw new Exception("Радиус не может быть отрицательным");
        }
        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
