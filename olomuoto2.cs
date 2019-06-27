using System;
namespace Olomuoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = new int();

            Console.WriteLine("Syötä jokin lämpötila kokonaislukuna: ");
            luku = int.Parse(Console.ReadLine());
            if (luku < 0)
            {
                Console.WriteLine("Jäätä.");
            }
            else if (luku >= 0 && luku <= 100)
            {
                Console.WriteLine("Nestettä.");
            }
            else if (luku > 100)
            {
                Console.WriteLine("Höyryä.");
            }
            Console.WriteLine("Haluatko syöttää uuden luvun? (k/e) ");
            while (Console.ReadLine() == "k") ;
        }
    }
}