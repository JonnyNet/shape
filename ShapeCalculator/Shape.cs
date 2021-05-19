using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public abstract class Shape
    {
        public double P1 { get; set; }
        public double P2 { get; set; }

        public virtual double GetArea()
        {
            return this.P1 * this.P2;
        }
    }
}
