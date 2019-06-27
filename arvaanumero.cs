using System;

namespace ArvaaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
             Random random = new Random();
             int numero = random.Next(1, 100);

            Console.WriteLine("Arvaa numero: ");
            int arvaus = Int32.Parse(Console.ReadLine());

            if (arvaus == numero)
            {
                Console.WriteLine("Mahtavaa, arvasit numeron!");
                Console.WriteLine("Haluatko koittaa uudestaan? (k/e)?: ");
                while (Console.ReadLine() == "k");
            }
            else if (arvaus > numero && arvaus > 0 && arvaus < 101)
            {
                Console.WriteLine("Numero ei ole noin iso.");
            }
            else if (arvaus < numero && arvaus > 0 && arvaus < 101)
            {
                Console.WriteLine("Numero ei ole noin pieni.");
            }
            else
            {
                Console.WriteLine("Arvaus on rajojen ulkopuolella.");
            }
        }
    }
}