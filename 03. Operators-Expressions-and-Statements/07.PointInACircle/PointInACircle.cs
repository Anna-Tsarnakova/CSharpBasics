/* Problem 7. Point in a Circle
Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
Examples:
x	   y	 inside
0	   1	 true
-2	   0	 true
-1	   2	 false
1.5	  -1	 true
-1.5  -1.5	 false
100	  -30	 false
0	   0	 true
0.2	  -0.8	 true
0.9	  -1.93	 false
1	  1.655	 true
*/

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        int radius = 2;
        //If the point (x,  y) is inside the circle K({0, 0}, 2), therefore (x * x + y * y) < radius * radius
        bool isInCircle = (x * x + y * y) < radius * radius;
        Console.WriteLine("Is the point ({0}, {1}) inside the circle? {2}", x, y, isInCircle);
    }
}

