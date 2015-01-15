/* Problem 3. Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area 
formatted with 2 digits after the decimal point. 
 Examples:
r	 perimeter	area
2	 12.57	    12.57
3.5	 21.99	    38.48
 */ 

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("r = ");
        //Reads the radius r of a circle
        double r = double.Parse(Console.ReadLine());

        //Calculates a perimeter and an area of the circle
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;

        //Prints the perimeter and the area of the circle
        Console.WriteLine("perimeter = {0:F2}", perimeter);
        Console.WriteLine("area = {0:F2}", area);
    }
}