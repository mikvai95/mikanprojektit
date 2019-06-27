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
            string str, str1 = "";
            int i, l;

            Console.Write("\n\n");
            Console.Write("Tulostetaan merkkijono väärinpäin.\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Anna merkkijono: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i=l;i>=0;i--)
            {
                str1 = str1 + str[i];
            }

            Console.WriteLine("Merkkijono väärinpäin on : {0}", str1);
            Console.Write("\n");
        }
    }
}
