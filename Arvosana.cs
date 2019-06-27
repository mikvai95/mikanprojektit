using System;

namespace Arvosana
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvosana;

        label:

            Console.Write("Syötä arvosana 1 ja 10 väliltä: ");
            arvosana = Convert.ToInt32(Console.ReadLine());

            switch (arvosana)
            {
                case 1:
                case 2:
                    Console.WriteLine("Huono");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Kohtalainen");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Hyvä");
                    break;
                case 9:
                    Console.WriteLine("Kiitettävä");
                    break;
                case 10:
                    Console.WriteLine("Erinomainen");
                    break;
                default:
                    Console.WriteLine("Virheellinen arvosana.");
                    goto label;
            }
            Console.WriteLine("Arvosanasi on  {0}", arvosana);
            Console.ReadLine();
        }
    }
}
