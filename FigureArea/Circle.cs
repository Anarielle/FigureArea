using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Radius = radius;
        }

        public override double CalcArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);

            if (Double.IsInfinity(Area))
            {
                throw new OverflowException();
            }
            else
            {
                return Area;
            }
        }
    }
}
