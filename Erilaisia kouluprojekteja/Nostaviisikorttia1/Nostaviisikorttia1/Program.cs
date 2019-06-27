using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nostaviisikorttia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int card;
            string[] nostetut = { "", "", "", "", "" };
            Random randomcard = new Random();
            string temp;
            int n = 0;
            string[] kortit =
            {
                "H1","H2","H3","H4","H5","H6","H7","H8","H9","HT","HJ","HQ","HK",
                "P1","P2","P3","P4","P5","P6","P7","P8","P9","PT","PJ","PQ","PK",
                "Ru1","Ru2","Ru3","Ru4","Ru5","Ru6","Ru7","Ru8","Ru9","RuT","RuJ","RuQ","RuK",
                "Ri1","Ri2","Ri3","Ri4","Ri5","Ri6","Ri7","Ri8","Ri9","RiT","RiJ","RiQ","RiK"
            };

            for (int i = 0; i < 5; i++)
            {
                card = randomcard.Next(1, 52);
                temp = kortit[card];

                if (!nostetut[n].Contains(temp))
                {
                    nostetut[n] = temp;
                    n++;
                }
                else { i--; }
            }

            var shuffle = kortit.OrderBy(kortti => randomcard.Next());

            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("Sinulle arvottiin kortit:", nostetut[j]);
                Console.WriteLine(string.Join(", ", shuffle.Skip(j * 5).Take(5)));

                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
