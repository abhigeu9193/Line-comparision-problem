using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    internal class CalculateLength
    {
        public void length()
        {
            double x1 = 1, x2 = 2, y1 = 1, y2 = 2;
            double length;
            length = Math.Sqrt(x2 - x1) + Math.Pow(2, 4) + Math.Sqrt(y2 - y1) + Math.Pow(2, 4);

            Console.WriteLine(length);
        }
    }
}
