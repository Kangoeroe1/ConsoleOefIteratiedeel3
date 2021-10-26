using System;

namespace ConsoleOefIteratiedeel3
{
    class Program
    {
        static void Main(string[] args)
        {
            //oef1
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hallo");
            //}
            //Console.ReadKey();

            //OF

            //int i = 0;
            //while (i <= 5)
            //{
            //    Console.WriteLine("Hallo");
            //    i++;
            //}
            //Console.ReadKey();

            //oef2
            //string zin = "Hallo";
            //for (int i = 5; i <= 5; i--)
            //{
            //    string zin1 = zin.Substring(0, i);
            //    Console.WriteLine(zin1);
            //}
            //Console.ReadKey();

            //oef3
            Console.WriteLine("Geef het getal in om door 2 te delen");
            double getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= getal; i++)
            {
                if (getal >= 1)
                {
                    getal /= 2;
                    Console.WriteLine(getal);
                }
                else 
                {
                    Console.WriteLine("Jammer");
                }
            }
            Console.ReadKey();
        }
    }
}
