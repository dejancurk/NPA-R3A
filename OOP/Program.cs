namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pacient P1 = new("Janez", "Novak", 1987, 1.80, 80.0);
            Pacient P2 = new("France", "Hrovat", 1987, 1.82, 80.0);

            Console.WriteLine(P1.izracunajITM());
            P1.izpisPacienta();
            P2.izpisPacienta();
        }
    }
}