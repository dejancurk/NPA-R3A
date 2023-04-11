using System;

namespace Metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stevilo = 1;
            while (stevilo != 0)
            {
                Console.Write("Vpiši poljubno število: ");
                stevilo = int.Parse(Console.ReadLine());
                int fakt = fakulteta(stevilo);
                Console.WriteLine($"{stevilo}! = {fakt}"); 
            }

            int x = fakulteta(5);
            Console.WriteLine(x);
            int y = 10;
            x = fakulteta(y);
            Console.WriteLine(x);

            Console.WriteLine(fakulteta(6));

        }

        static public int fakulteta(int n)
        {
            int fakt = 1;

            for(int i = 1; i <= n; i++)
            {
                fakt = fakt * i;
            }

            return fakt;
        }
    }
}