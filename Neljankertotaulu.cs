using System;

namespace Kertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int luku = 4;

            while (i <= 10)
            {
                Console.WriteLine("i * luku = {0}", i);
                Console.WriteLine("Paina Enteriä jatkaaksesi...");
                Console.ReadLine();

                i++;
            }
        }
    }
}
