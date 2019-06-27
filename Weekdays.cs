using System;

namespace Weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string result;

        label:

            Console.Write("Syötä numero 1 ja 7 väliltä: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    result = "Monday";
                    Console.WriteLine("{0} => {1}st day of the week", result, num);
                    break;
                case 2:
                    result = "Tuesday";
                    Console.WriteLine("{0} => {1}nd day of the week", result, num);
                    break;
                case 3:
                    result = "Wednesday";
                    Console.WriteLine("{0} => {1}rd day of the week", result, num);
                    break;
                case 4:
                    result = "Thursday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 5:
                    result = "Friday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 6:
                    result = "Saturday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                case 7:
                    result = "Sunday";
                    Console.WriteLine("{0} => {1}th day of the week", result, num);
                    break;
                default:
                    Console.WriteLine("Virheellinen päivä.");
                    goto label;
            }
        }
    }
}
