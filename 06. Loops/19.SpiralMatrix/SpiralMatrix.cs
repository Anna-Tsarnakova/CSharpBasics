/* Problem 19.** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
Examples:
n	 matrix		 n	 matrix		  n  	matrix
2    1 2         3   1 2 3        4     1  2  3  4      
     3 4             8 9 4              12 13 14 5
                     7 6 5              11 16 15 6
                                        10 9  8  7
*/
using System;

class SpiralMatrix
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int counter = 1;
        int row = 0;
        int col = 0;
        int maxRow = n - 1;
        int maxCol = n - 1;

        if (n >= 1 && n <= 20)
        {
            while (counter <= n * n)
            {
                for (int i = col; i <= maxCol; i++) //right direction
                {
                    array[row, i] = counter++;
                }
                row++;

                for (int i = row; i <= maxRow; i++) //down direction
                {
                    array[i, maxCol] = counter++;
                }
                maxCol--;

                for (int i = maxCol; i >= col; i--) //left direction
                {
                    array[maxRow, i] = counter++;
                }
                maxRow--;

                for (int i = maxRow; i >= row; i--) //up direction
                {
                    array[i, col] = counter++;
                }
                col++;
            }
            //Display the matrix
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0, 4}", array[rows, cols]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Ivalid input! 1 <= n <= 20");
        }
    }
}
