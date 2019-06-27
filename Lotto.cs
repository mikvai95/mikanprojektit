using System;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int numero;
                int[] lotto = new int[7];
                Random sattuma = new Random();
                for (int i = 0; i < 7; i++)
                {
                    numero = sattuma.Next(1, 41);

                    if (!lotto.Contains<int>(numero))
                    {
                        lotto[i] = numero;
                    }
                    else { lotto[i - 1] = numero; }

                }
                Array.Sort(lotto);

                
                Console.Write("Viikon lottonumerot ovat: ");
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(lotto[j] + " ");
                }

            }
        }
    }
}

