using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new Dictionary<int, Shape>
            {
                { 0, new Cilcle() },
                { 1, new Rectangle() }
            };

            var option = -1;
            while (option != 0 && option != 1)
            {
                Console.WriteLine("Calculate area of a shape, 0 for circle, 1 for rectangle");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { continue; }
            }

            var text = option == 0 ? "Radio" : "P1";

            if (strategy.TryGetValue(option, out Shape shape))
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter {text}:");
                        shape.P1 = double.Parse(Console.ReadLine());
                        if(option == 0) { break; }

                        Console.WriteLine($"Enter P2:");
                        shape.P2 = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch { continue; }
                }

                Console.WriteLine($"Area of a shape: {shape.GetArea()}:");
                Console.ReadLine();
            }

        }
    }
}
