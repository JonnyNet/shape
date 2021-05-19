using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Cilcle : Shape
    {
        public override double GetArea()
        {
            var radio = Math.Pow(this.P1, 2);
            return 3.1415 * radio;
        }
    }
}
