/* Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
52130, -115, 4825932, 97, -10000. 
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. 
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        sbyte variableOne = -115;
        byte variableTwo = 97;
        short variableThree = -10000;
        ushort variableFour = 52130;
        uint variableFive = 4825932;
        Console.WriteLine("{0} -> sbyte \n{1} -> byte \n{2} -> short \n{3} -> ushort \n{4} -> unit ", variableOne, variableTwo, variableThree, variableFour, variableFive);

    }
}

