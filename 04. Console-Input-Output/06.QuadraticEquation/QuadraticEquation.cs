/* Problem 6. Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
Examples:
     a   b    c | roots         
     2   5   -3 | x1=-3; x2=0.5 
    -1   3    0 | x1=3; x2=0    
  -0.5   4   -8 | x1=x2=4       
     5   2    8 | no real roots 
*/ 

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4.0 * a * c;

        if (a != 0)
        {
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2.0 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if (d == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots!");
            }
        }
        else
        {
            Console.WriteLine("The coefficient a can't be equal to 0!");
        }
    }
}

