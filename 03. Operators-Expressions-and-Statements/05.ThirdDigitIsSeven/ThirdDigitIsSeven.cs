/* Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7. 
Examples:
n	     Third digit 7?
5	     false
701      true
9703     true
877	     false
777877	 false
9999799	 true
*/ 

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        byte thirdDigit = 7;
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isThirdDigit = ((number / 100) % 10 == thirdDigit || (-number / 100) % 10 == thirdDigit);
        Console.WriteLine("Third digit is 7? {0}", isThirdDigit);
    }
}

