using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Figure
    {
        public double Area { get; set; }

        public Figure()
        {
        }

        public virtual double CalcArea()
        {
            return Area;
        }
    }
}
