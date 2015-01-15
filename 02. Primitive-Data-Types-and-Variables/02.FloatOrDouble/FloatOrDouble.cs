/* Problem 2. Float or Double?
Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;
class FloatOrDouble
{
    static void Main()
    {
        float floatNumOne = 12.345f;
        float floatNumTwo = 3456.091f;
        double doubleNumOne = 34.567839023d;
        double doubleNumTwo = 8923.1234857d;

        Console.WriteLine("The variables {0} and {1} are of type float!", floatNumOne, floatNumTwo);
        Console.WriteLine("The variables {0} and {1} are of type double!", doubleNumOne, doubleNumTwo);
    }
}

