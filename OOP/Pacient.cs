using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Pacient
    {
        string ime; string priimek; int leto_rojstva; double visina;
        double teza;
        public Pacient(string ime, string priimek, int leto_rojstva, double visina, double teza)
        {
            this.leto_rojstva = leto_rojstva;
            this.ime = ime;
            this.priimek = priimek;
            this.visina = visina;
            this.teza = teza;
        }
        public double izracunajITM()
        {
            return teza / Math.Pow(visina,2);
        }

        public void izpisPacienta()
        {
            Console.WriteLine(ime + " " + priimek);
        }
    }
}
