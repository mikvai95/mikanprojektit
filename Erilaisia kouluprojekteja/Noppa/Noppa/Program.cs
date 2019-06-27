using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Noppa1 = new int[6];
            int[] Noppa2 = new int[6];
            Random rng = new Random();
            int sum=0;

            Console.WriteLine("Tervetuloa noppapeliin! Saat heittää kahta noppaa viisi kertaa, jonka jälkeen peli tulostaa heittojen tulokset.");
            Console.WriteLine("Paina Enteriä aloittaaksesi.");
            Console.Read();

            for (int i = 0; i < 5; i++)
            {
                //int heitto1 = 0;
                //int heitto2 = 0;
                //heitto1 = rng.Next(7);
                Noppa1[i] = rng.Next(1,7);
                Console.WriteLine("Nopan 1 silmäluku on: {0}", Noppa1[i]);
                //heitto2 = rng.Next(6);
                Noppa2[i] = rng.Next(1,7);
                Console.WriteLine("Nopan 2 silmäluku on: {0}", Noppa2[i]);
                Console.WriteLine("Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
            }
                {
                Console.WriteLine("Paina Enteriä nähdäksesi tulokset.");
                Console.ReadLine();
                }

                Console.WriteLine("Tulos yhteensä: ");
                for (int i = 0; i < 5; i++)
                {
                    sum += Noppa1[i] + Noppa2[i];
                    
                }

            Console.Write(sum);
        }
    }
}