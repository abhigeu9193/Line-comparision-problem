// See https://aka.ms/new-console-template for more information geometry1

   // private static int axisCheck;

   // static void Main(string[] args)
    
        double x1 = 1, x2 = 2, y1 = 1, y2 = 2;
        double length;
        length = Math.Sqrt(x2 - x1) + Math.Pow(2, 4) + Math.Sqrt(y2 - y1) + Math.Pow(2, 4);

        Console.WriteLine(length);
int x = 0, y = 0;

/*   Q2  */
Random random = new Random();
int xaxisCheck = random.Next(0, 2);
int yaxisCheck = random.Next(0, 2);
Console.WriteLine(random);
if (xaxisCheck == yaxisCheck)

    Console.WriteLine("true");

else

    Console.WriteLine("false");

/*Q3*/
Console.WriteLine(random);
if (xaxisCheck > yaxisCheck)

    Console.WriteLine("Greatest");

else if (yaxisCheck < xaxisCheck)

    Console.WriteLine("Lowest");

else

    Console.WriteLine("Equal");









