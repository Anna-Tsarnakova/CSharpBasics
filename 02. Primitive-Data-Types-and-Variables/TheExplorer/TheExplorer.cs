using System;


class TheExplorer

{
    private static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = width;
        string star = "*";
        string dash = "-";
        int lowerNumber = width/2;
        int upperNumber = width/2;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 && j == width/2)
                {
                    Console.Write(star);
                }
                else if (i > 0 && j == lowerNumber)
                {
                    Console.Write(star);
                }
                else if (i > 0 && j == upperNumber)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dash);
                }
            }

            if (i < width/2)
            {
                lowerNumber--;
                upperNumber++;
            }
            else
            {
                lowerNumber++;
                upperNumber--;
            }

            Console.WriteLine();




            ////Second solution with loops
            //char star = '*';

            //int a = 4; //side a = b = 4 copyrights

            //for (int i = 0; i < a; i++) //rows
            //{
            //    for (int j = 1; j <= a + i; j++) //spaces in the row
            //    {
            //        if (j == a - i || j == a + i)
            //        {
            //            Console.Write(star);
            //        }
            //        else
            //        {
            //            Console.Write("-");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 2; i >= 0; i--) //rows
            //{
            //    for (int j = 1; j <= a + i; j++) //spaces in the row
            //    {
            //        if (j == a - i || j == a + i)
            //        {
            //            Console.Write(star);
            //        }
            //        else
            //        {
            //            Console.Write("-");
            //        }

            //    }
            //    Console.WriteLine();
            //}


        }
    }
}

