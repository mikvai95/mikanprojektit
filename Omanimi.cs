using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoittelua
{
    class Program
    {
        public static void Main()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Tämä ohjelma näyttää tähtimerkeillä tehdyn oman nimeni.\n");
            Console.Write("-------------------------------------------------------");
            Console.Write("\n\n");

            for(row = 0; row <= 6; row++)
            {
                for(column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for(row = 0; row <= 6; row++)
            {
                for(column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            int j = 5, i = 0;

            for (row = 0; row <= 6; row++)
            {
                for(column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                        Console.Write("*");

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for(row = 0; row <= 7; row++)
            {
                for(column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) || ((row == 0 || row == 3) && (column > 1 && column < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");

            for(row = 0; row <= 6; row++)
            {
                for(column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (row = 0; row <= 7; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) || ((row == 0 || row == 3) && (column > 1 && column < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
