using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoittelua
{
    class Program
    {
        static void Main(string[] args)
        {
            string kayttajatunnus, salasana;
            int ctr = 0;
            Console.Write("\n\nTarkistetaan käyttäjätunnus ja salasana :\n");
            Console.Write("Oletuksena kayttajatunnus ja salasana on: abcd ja 1234\n");
            Console.Write("------------------------------------------------------");

            do
            {
                Console.Write("Anna käyttäjätunnus: ");
                kayttajatunnus = Console.ReadLine();

                Console.Write("Anna salasana: ");
                salasana = Console.ReadLine();

                if (kayttajatunnus != "abcd" || salasana != "1234")
                    ctr++;
                else
                    ctr = 1;
            }
            while ((kayttajatunnus != "abcd" || salasana != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nKirjautumista on yritetty kolme kertaa tai enemmän. Yritä myöhemmin uudelleen!\n\n");
            else
                Console.Write("\nSalasana on oikein!\n\n");
        }
    }
}
