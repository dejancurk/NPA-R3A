using System;

namespace Tabele_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int[,] kepice_sladoleda = new int[12, 3];

            for (int i = 0; i < kepice_sladoleda.GetLength(0); i++)
                for (int j = 0; j < kepice_sladoleda.GetLength(1); j++)
                    kepice_sladoleda[i, j] = r.Next(1, 151);

            for(int i = 0; i < kepice_sladoleda.GetLength(0); i++)
            {
                for (int j = 0; j < kepice_sladoleda.GetLength(1); j++)
                    Console.Write($"{kepice_sladoleda[i,j],-7}");
                Console.WriteLine();
            }

        }
    }
}