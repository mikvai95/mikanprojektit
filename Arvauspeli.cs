using System;

namespace Arvauspeli
{
    class Peli
    {
        int peli = 0;
        int Target = 5;
        string Input = "";
        string[] Sanat = { "spyro", "sparx", "ripto", "moneybags", "hunter" };
        Random RandomNumber = new Random();

        public void Play()
        {
            Target = RandomNumber.Next(Sanat.Length);

            Console.Write(" Arvaa sana: ");
            for (int i = 0; i < Sanat.Length; i++)
            {
                if (i == (Sanat.Length - 1))
                    Console.Write("or " + Sanat[i] + "? ");
                else
                    Console.Write(Sanat[i] + ", ");
            }

            Input = Console.ReadLine();

            if (Input == Sanat[Target])
            {
                Console.WriteLine("Mahtavaa! Arvasit sanan!");
            }
            else
            {
                Console.WriteLine("Arvauksesi ei osunut oikeaan, yritä uudestaan!");
                Console.WriteLine("Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
                Play();
            }

            Console.ReadKey();
        }
    }
}