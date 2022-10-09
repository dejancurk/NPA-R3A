using System;

namespace Tabele_1D
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* temperature
            Random r = new Random();
            double[] temperature = new double[10];

            for(int i = 0; i < 10; i++)
            {
                temperature[i] = r.NextDouble()*40;
            }

            foreach(double t in temperature)
                Console.WriteLine(t);

            for(int i = 0; i < temperature.Length; i++)
            {
                Console.WriteLine($"{i}: {temperature[i]}");
            }
            */

            Random r = new Random();
            int[] nakljucna = new int[100];

            for(int i= 0; i < nakljucna.Length; i++)
            {
                nakljucna[i] = r.Next(1,51);
            }

            int vnos = int.Parse(Console.ReadLine());
            int stevec = 0;

            for (int i = 0; i < nakljucna.length; i++)
            {
                if (nakljucna[i] == vnos)
                {
                    stevec++;
                    Console.WriteLine(i);
                }
            }


            if (stevec == 0)
            {
                Console.WriteLine("Števila ni tabeli");
            } else
                Console.WriteLine($"Število se pojavi {stevec}-krat");
        }
    }
}