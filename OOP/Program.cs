namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pacient P1 = new Pacient("Janez", "Novak", 1987, 1.80, 80.0);
            Pacient P2 = new Pacient("France", "Hrovat", 1987, 1.82, 80.0);

            Console.WriteLine(P1.izracunajITM());
        }
    }
}