using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laivanupotus
{
    class Laivanupotuspelialusta
    {
        public void DisplayBoard(char[,] Pelialusta)
        {
            int Rivi;
            int Sarake;

            Console.WriteLine(" | 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+-------------------");
            for (Rivi = 0; Rivi <= 9; Rivi++)
            {
                Console.Write((Rivi).ToString() + " | ");
                for (Sarake = 0; Sarake <= 9; Sarake++)
                {
                    Console.Write(Pelialusta[Sarake, Rivi] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        
        }
    }
    class Pelaaja
    {
        char[,] Ruudukko = new char[10, 10];
        public int Osumat = 0;
        public int Hudit = 0;
        int x = 0;
        int y = 0;

        public int getOsumat()
        {
            return Osumat;
        }
        public int getHudit()
        {
            return Hudit;
        }
        public void KysyKoordinaatit()
        {
            Console.WriteLine("Anna X-koordinaatti.");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Et syöttänyt kokonaislukua!");
            }

            Console.WriteLine("Anna Y-koordinaatti.");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Et syöttänyt kokonaislukua!");
            }

            try
            {
                if (Ruudukko[x, y].Equals('L'))
                {
                    Ruudukko[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Osuma!\r\n");
                    Osumat += 1;
                }
                else
                {
                    Ruudukko[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Huti!\r\n");
                    Hudit += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Virhe! Anna numeroita nollan ja yhdeksän väliltä.");
            }
        }
        public char[,] GetRuudukko()
        {
            return Ruudukko;
        }
        public void SetRuudukko(int q, int w)
        {
            Ruudukko[q, w] = 'L';
        }
        public void Sattuma()
        {
            Random rng = new Random(2);
            // Yksi laiva, joka on kahden ruudun pituinen
            SetRuudukko(1, 2);
            SetRuudukko(2, 2);
            // Kaksi laivaa, jotka ovat kolmen ruudun pituisia
            SetRuudukko(4, 3);
            SetRuudukko(4, 4);
            SetRuudukko(4, 5);

            SetRuudukko(5, 0);
            SetRuudukko(6, 0);
            SetRuudukko(7, 0);
            // Yksi laiva, joka on neljän ruudun pituinen
            SetRuudukko(0, 8);
            SetRuudukko(1, 8);
            SetRuudukko(2, 8);
            SetRuudukko(3, 8);
            // Yksi laiva, joka on viiden ruudun pituinen
            SetRuudukko(7, 4);
            SetRuudukko(7, 5);
            SetRuudukko(7, 6);
            SetRuudukko(7, 7);
            SetRuudukko(7, 8);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Taistelevat Laivat!";
            Console.WriteLine("Tervetuloa Taisteleviin Laivoihin!\r\n\r\n");
            Console.WriteLine("Anna nimesi: ");
            string nimi = System.Console.ReadLine();
            Console.WriteLine();
            Laivanupotuspelialusta l = new Laivanupotuspelialusta();
            Pelaaja p = new Pelaaja();
            p.Sattuma();
            while (p.getOsumat() < 17)
            {
                l.DisplayBoard(p.GetRuudukko());
                p.KysyKoordinaatit();
            }
            Console.WriteLine("Onnea, " + nimi + "! Sinä voitit!\r\n");
            Console.WriteLine("Huteja tuli: " + p.getHudit() + " yhteensä.\r\n");
            Console.WriteLine("Kiitos kun pelasit Taistelevia Laivoja. Paina Enteriä lopettaaksesi.");
            System.Console.ReadLine();
        }
    }
}

