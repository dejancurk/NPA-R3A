using System;
using System.Security.Authentication.ExtendedProtection;

namespace _10_Datoteke___Vaja_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] stevila = new int[r.Next(1, 101)];
            for(int i = 0; i < stevila.Length; i++)
            {
                stevila[i] = r.Next(10,100);
            }
            zapisiVdat(stevila);
            /*for(int i = 0; i < 3; i++)
            {
                Console.Write("Vnesi svoje ime: ");
                string ime = Console.ReadLine();
                Console.Write("Vnesi svoj priimek: ");
                string priimek = Console.ReadLine();

                zapisiVdatImePriimek(ime, priimek);
                
            }*/

            int[] loto = new int[7];

            for(int i = 0; i < loto.Length; i++)
            {
                int zogica = r.Next(1, 40);
                while (loto.Contains(zogica))
                {
                    zogica = r.Next(1, 40);
                }
                loto[i] = zogica;
            }

            using (StreamWriter dat = new StreamWriter("loto.csv"))
            {
                foreach (int zogica in loto)
                    dat.Write(zogica + ";");
            }

            using (StreamReader dat = new StreamReader("datoteka.txt"))
            {
                using(StreamWriter dapat = new StreamWriter("dapatopotepekapa.txt"))
                {
                    while (dat.Peek() >= 0)
                    {
                        string samoglasniki = "aeiouAEIOU";
                        char znak = (char)dat.Read();
                        if (samoglasniki.Contains(znak))
                        {
                            dapat.Write(znak+"p"+znak);
                        }
                        else
                        {
                            dapat.Write(znak);
                        }
                    }
                }
                
            }
        }
        static void zapisiVdat(int[] tabela)
        {
            using (StreamWriter dat = new StreamWriter("tabela.txt", true))
            {
                foreach(int st in tabela)
                {
                    dat.WriteLine(st);
                }
            }
        }

        static void zapisiVdatImePriimek(string n, string p)
        {
            using (StreamWriter dat = new StreamWriter("imena.txt", true))
            {
                dat.WriteLine(n + " "+ p);
            }
        }

        
    }
}