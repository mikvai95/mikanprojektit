using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte luku1, luku2; // luku3 ei toimi, koska byte: 0 - 255
            int luku3; // siksi muutetaan luku3 integeriksi: -> -2,147,483,648 - 2,147,483,647
            luku1 = 100;
            luku2 = 200;
            //luku3 = luku1 + luku2; Ei toimi, koska byte = 0 - 255 ja vastaus on 300
            luku3 = luku1 + luku2;
            Console.WriteLine(luku3);
        }
    }
}
--------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 3, luku2 = 2; // luku3; // tulostaa kokonaisluvun, koska luku3 on kokonaisluku
            double luku3; // siitä syystä luku3 = double, float tai decimal
            luku3 = (double)luku1 / luku2; // tulostaa kokonaisluvun, koska int / int = int, sen takia double -muunnos
            Console.WriteLine(luku3);
        }
    }
}
-------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tulos = ((double)25 * 5 / 100);
            Console.WriteLine(tulos);
        }
    }
}
-------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String merkki = "O";
            String sana = "hjelmointi";
            Console.WriteLine(merkki + sana);
        }
    }
}
-------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.Write("Anna ikäsi: ");
            ika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Olet " + ika + " vuotta!");
        }
    }
}
--------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuumamitta, senttimitta;
            Console.Write("Anna mitta tuumina: ");
            tuumamitta = Convert.ToDouble(Console.ReadLine());
            senttimitta = tuumamitta * 2.54;
            Console.WriteLine(tuumamitta + " tuumaa on " + senttimitta + " senttiä!");
        }
    }
}
---------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            Console.Write("Anna tulon 1. luku: ");
            luku1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anna tulon 2. luku: ");
            luku2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " tulo on " + luku1 * luku2);
        }
    }
}
----------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paljonko irtokarkit maksavat / kg? ");
            hinta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Paljonko sinulla on rahaa käytettävissäsi? ");
            rahaa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(rahaa + " eurolla saa " + String.Format("{0:0.00}", rahaa / hinta)
              + " kiloa karkkia, jotka maksavat " + hinta + " / kg");
            // String.Format("{0:0.00}", value) muotoilee luvun kahteen desimaaliin
        }
    }
}
------------------------------------------------------------------------------------------------
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double palkka, vero, netto;

            Console.Write("Paljonko bruttopalkkasi on? ");
            palkka = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mikä on veroprosenttisi? Anna se desimaalilukuna, esimerkiksi 0,25: ");
            vero = Convert.ToDouble(Console.ReadLine());
            netto = palkka - (palkka * vero);
            Console.WriteLine("Bruttopalkkasi on: \t" + palkka + " euroa");
            Console.WriteLine("Veroa maksat siitä: \t" + String.Format("{0:0.00}", palkka * vero ) + " euroa");
            Console.WriteLine("Käteen sinlle jää: \t" + String.Format("{0;0.00)", netto ) + " euroa");
            // String.Format("{0:0.00}", value) muotoilee luvun kahteen desimaaliin
        }
    }
}
using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pituus, paino, BMI;

            Console.Write("Mikä on pituutesi metreinä (esim. 1,65)? ");
            pituus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mikä on painosi kiloina (esim. 65)? ");
            paino = Convert.ToDouble(Console.ReadLine());
            BMI = paino / (pituus * pituus);
            Console.WriteLine("Painosi on: \t\t" + paino + " kiloa");
            Console.WriteLine("Pituutesi on: \t\t" + pituus + " senttiä");
            Console.WriteLine("Painoindeksisi on: \t" + String.Format("{0:0.00}", BMI));
            // String.Format("{0:0.00}", value) muotoilee luvun kahteen desimaaliin
        }
    }
}