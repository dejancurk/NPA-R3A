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

            //Random r = new Random();
            //int[] nakljucna = new int[100];

            //for(int i= 0; i < nakljucna.Length; i++)
            //{
            //    nakljucna[i] = r.Next(1,51);
            //}

            //int vnos = int.Parse(Console.ReadLine());
            //int stevec = 0;

            //for (int i = 0; i < nakljucna.length; i++)
            //{
            //    if (nakljucna[i] == vnos)
            //    {
            //        stevec++;
            //        Console.WriteLine(i);
            //    }
            //}


            //if (stevec == 0)
            //{
            //    Console.WriteLine("Števila ni tabeli");
            //} else
            //    Console.WriteLine($"Število se pojavi {stevec}-krat");

            Random r = new Random();
            int[] seznam = new int[10];

            for (int i = 0; i < seznam.Length; i++)
            {
                seznam[i] = r.Next(1, 101);
            }
            foreach (int e in seznam)
                Console.Write(e + ",");
            Console.WriteLine();

            Console.WriteLine("===========");

            //for (int k=0; k < 10; k++)
            //{
            int temp = seznam[0];
            for (int i = 1; i < seznam.Length; i++)
            {
                seznam[i - 1] = seznam[i];
            }
            seznam[seznam.Length - 1] = temp;
            //Console.WriteLine($"{k + 1}. rošada:");
            //foreach (int e in seznam)
            //    Console.Write(e + ",");
            //Console.WriteLine();
            //}

            // naloga 3
            //int[] sortirana = new int[20];
            //for (int i = 0; i < sortirana.Length; i++)
            //{
            //    sortirana[i] = r.Next(100, 201);
            //}

            //Array.Sort(sortirana);

            //foreach (int e in sortirana) Console.WriteLine(e);

            //Array.Reverse(sortirana);
            //Console.WriteLine("Obratno:");
            //foreach (int e in sortirana) Console.WriteLine(e);

            //naloga 4
            //int[] samoenkrat = new int[50];
            //for (int i = 0; i < samoenkrat.Length; i++)
            //{
            //    samoenkrat[i] = r.Next(1, 21);
            //}

            //foreach (int e in samoenkrat)
            //    Console.Write($"{e},");
            //Console.WriteLine();

            //foreach (int e in samoenkrat)
            //{
            //    if (samoenkrat.Count(x => x == e) == 1)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            //seznam.Count(); //koliko je elementov v seznamu
            //seznam.Count(x => x == 0); // koliko je ničel v seznamu


            int[] kolikokrat = new int[100];
            for (int i = 0; i < kolikokrat.Length; i++)
            {
                kolikokrat[i] = r.Next(1, 51);
            }

            for(int i=1; i<=50; i++)
            {
                Console.WriteLine($"{i} se pojavi {kolikokrat.Count(x => x == i)} krat.");

            }

            int[] tabela = r.Next(101){1,1000};
        }
    }
}