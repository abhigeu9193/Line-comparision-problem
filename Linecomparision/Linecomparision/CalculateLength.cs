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
            int x = 0, y = 0;


            Random random = new Random();
            int xaxisCheck = random.Next(0, 2);
            int yaxisCheck = random.Next(0, 2);
            Console.WriteLine(random);
            if (xaxisCheck == yaxisCheck)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }



               Console.WriteLine(length);
        }
    }
}
