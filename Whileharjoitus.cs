using System;

namespace Whileharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine("Mika Vaine", i);
                Console.WriteLine("Paina Enteriä jatkaaksesi.");
                Console.ReadLine();

                i++;

            }
        }
    }
}
