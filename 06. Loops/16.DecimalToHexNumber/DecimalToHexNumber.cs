/* Problem 16. Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. 
The output should be a variable of type string. Do not use the built-in .NET functionality. 
Examples:
decimal	        hexadecimal
254	            FE
6883        	1AE3
338583669684	4ED528CBB4
*/

using System;

class DecimalToHexNumber
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string hexNumber = String.Empty;

        while (decNumber != 0)
        {
            switch (decNumber % 16)
            {
                case 10:
                    hexNumber += 'A'; break;
                case 11:
                    hexNumber += 'B'; break;
                case 12:
                    hexNumber += 'C'; break;
                case 13:
                    hexNumber += 'D'; break;
                case 14:
                    hexNumber += 'E'; break;
                case 15:
                    hexNumber += 'F'; break;
                default: hexNumber += decNumber % 16;
                    break;
            }
            decNumber /= 16;
        }

        if (decNumber == 0)
        {
            hexNumber = "0";
        }

        //Output - first variant
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();

        //Output - second variant
        //char[] reversedHex = hexNumber.ToCharArray();
        //Array.Reverse(reversedHex);
        //Console.WriteLine(reversedHex);
    }
}
