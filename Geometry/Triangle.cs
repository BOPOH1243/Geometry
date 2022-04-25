using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle:Figure
    {
        double edge_A { get; }
        double edge_B { get; }
        double edge_C { get; }
        public bool isTriangleRight //является ли треугольник прямоугольным
        {
            get
            {
                return (edge_A * edge_A + edge_B * edge_B == edge_C * edge_C) || 
                    (edge_A * edge_A + edge_C * edge_C == edge_B * edge_B) || 
                    (edge_C * edge_C + edge_B * edge_B == edge_A * edge_A);//как же длинно, может стоит использовать Math.Pow()? получается еще длиннее...
            }
        }
        public double perimeter//периметр
        {
            get
            {
                return edge_A + edge_B + edge_C;
            }
        }
        public double GetSquare()
        {
            var half_perimeter = perimeter / 2;
            return Math.Sqrt(half_perimeter * (half_perimeter - edge_A) * (half_perimeter - edge_B) * (half_perimeter - edge_C));
        }
        public Triangle(double edge_A, double edge_B, double edge_C)
        {
            this.edge_A = edge_A;
            this.edge_B = edge_B;
            this.edge_C = edge_C;
            //парочка проверок на дурака
            if((edge_A+edge_B<edge_C) | (edge_A+edge_C<edge_B) | (edge_B+edge_C<edge_A))
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");
            if (edge_A < 0 | edge_B < 0 | edge_C < 0)
                throw new ArgumentException("сторона не может быть отрицательной");
        }


    }
}
