/* Problem 12.* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 
Examples:
numbers	              result
3 -2 1 1 8	          -2 + 1 + 1 = 0
3 1 -7 35 22	      no zero subset
1 3 -4 -2 -1	      1 + -1 = 0
                      1 + 3 + -4 = 0
                      3 + -2 + -1 = 0
1 1 1 -1 -1	          1 + -1 = 0
                      1 + 1 + -1 + -1 = 0
                      1 + -1 + 1 + -1 = 0
                      …
0 0 0 0 0	          0 + 0 + 0 + 0 + 0 = 0
Hint: you may check for zero each of the 32 subsets with 32 if statements.
 */
using System;
using System.Linq;

class ZeroSubset
{
    static void Main()
    {
        string number = Console.ReadLine();
        string[] numbers = number.Split(' ');
        int[] elements = numbers.Select(int.Parse).ToArray();
        bool isZeroSubset = false;

        if (elements[0] == 0 && elements[1] == 0 && elements[2] == 0 && elements[3] == 0 && elements[4] == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", elements[0], elements[1], elements[2], elements[3],
                elements[4]);
        }
        else
        {
            if (elements[0] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} = 0", elements[0]);
            }
            if (elements[1] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} = 0", elements[1]);
            }
            if (elements[2] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} = 0", elements[2]);
            }
            if (elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} = 0", elements[3]);
            }
            if (elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} = 0", elements[4]);
            }
            if (elements[0] + elements[1] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[0], elements[1]);
            }
            if (elements[0] + elements[2] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[0], elements[2]);
            }
            if (elements[0] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[0], elements[3]);
            }
            if (elements[0] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[0], elements[4]);
            }
            if (elements[0] + elements[1] + elements[2] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[1], elements[2]);
            }
            if (elements[0] + elements[1] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[1], elements[3]);
            }
            if (elements[0] + elements[1] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[1], elements[4]);
            }
            if (elements[0] + elements[2] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[2], elements[3]);
            }
            if (elements[0] + elements[2] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[2], elements[4]);
            }
            if (elements[0] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[0], elements[3], elements[4]);
            }
            if (elements[0] + elements[1] + elements[2] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", elements[0], elements[1], elements[2], elements[3]);
            }
            if (elements[0] + elements[2] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", elements[0], elements[2], elements[3], elements[4]);
            }
            if (elements[0] + elements[1] + elements[2] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", elements[0], elements[1], elements[2], elements[3],
                    elements[4]);
            }
            if (elements[1] + elements[2] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[1], elements[2]);
            }
            if (elements[1] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[1], elements[3]);
            }
            if (elements[1] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[1], elements[4]);
            }

            if (elements[1] + elements[2] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[1], elements[2], elements[3]);
            }

            if (elements[1] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[1], elements[3], elements[4]);
            }

            if (elements[1] + elements[2] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", elements[1], elements[2], elements[3], elements[4]);
            }

            if (elements[2] + elements[3] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[2], elements[3]);
            }
            if (elements[2] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[2], elements[4]);
            }

            if (elements[2] + elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} + {2} = 0", elements[2], elements[3], elements[4]);
            }

            if (elements[3] + elements[4] == 0)
            {
                isZeroSubset = true;
                Console.WriteLine("{0} + {1} = 0", elements[3], elements[4]);
            }
        }

        if (isZeroSubset == false)
        {
            Console.WriteLine("no zero subset");
        }

    }
}