/* Problem 14. Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation. 
The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
Examples:
decimal	    binary
0	        0
3	        11
43691	    1010101010101011
236476736	1110000110000101100101000000
*/ 
using System;
using System.Linq;

class DecimalToBinaryNumber
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryNumber = String.Empty;
        
        while (decimalNumber != 0)
        {
            int result = decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber += result;
        }
        if (decimalNumber == 0)
        {
            binaryNumber = "0";
        }

        //Output - first variant
        char[] reversedBinary = binaryNumber.ToCharArray();
        Array.Reverse(reversedBinary);
        Console.WriteLine(reversedBinary);

        //Output - second variant
        //for (int i = binaryNumber.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(binaryNumber[i]);
        //}
        //Console.WriteLine();
    }
}