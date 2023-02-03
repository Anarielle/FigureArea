using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Figure
    {
        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide <= 0 || secondSide <= 0 || thirdSide <= 0) || 
                (firstSide + secondSide <= thirdSide) ||
                (secondSide + thirdSide <= firstSide) ||
                (thirdSide + firstSide <= firstSide))
            {
                throw new ArgumentOutOfRangeException();
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double CalcArea()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));

            if (Double.IsNaN(Area))
            {
                throw new OverflowException();
            }
            else
            {
                return Area;
            }
        }

        public bool IsRightAngled()
        {
            if (Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2) ||
                Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2) ||
                Math.Pow(ThirdSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2))
            {
                return true;
            }

            return false;
        }
    }
}
