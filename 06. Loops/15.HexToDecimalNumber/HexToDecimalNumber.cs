/* Problem 15. Hexadecimal to Decimal Number
Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. 
The output should be a variable of type long. Do not use the built-in .NET functionality. 
Examples:
hexadecimal	  decimal
FE	          254
1AE3	      6883
4ED528CBB4	  338583669684
 */

using System;

class HexToDecimalNumber
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        long decNumber = 0;
        int counter = 0;

        for (int i = hexNumber.Length - 1; i >=0; i--)
        {
            switch (hexNumber[i])
            {
                case 'A': decNumber += 10 * (long)Math.Pow(16, counter); break;
                case 'B': decNumber += 11 * (long)Math.Pow(16, counter); break;
                case 'C': decNumber += 12 * (long)Math.Pow(16, counter); break;
                case 'D': decNumber += 13 * (long)Math.Pow(16, counter); break;
                case 'E': decNumber += 14 * (long)Math.Pow(16, counter); break;
                case 'F': decNumber += 15 * (long)Math.Pow(16, counter); break;
                default: decNumber += (long)char.GetNumericValue(hexNumber[i]) * (long)Math.Pow(16, counter);
                    break;
            }
            counter++;
        }
        Console.WriteLine(decNumber);
    }
}

