using System.Runtime.InteropServices;

Console.WriteLine(9 + 9 + "Janez");

Console.WriteLine("Janez" + 9 + 9);

Console.WriteLine("C:\nova mapa\test.txt");

Console.WriteLine("C:\\moja mapa\test.\0txt\v");

Console.WriteLine(@"C:\moja mapa\test.txt");

Console.Write("Vnesi svoje ime: ");
string ime = Console.ReadLine();

for(int i = 0; i < ime.Length; i++)
{
    Console.WriteLine(ime[i]);
}

for(int i = ime.Length - 1; i >= 0; i--)
{
    Console.Write(ime[i]);
}
Console.WriteLine();

string samoglasniki = "aeiou";
for(int i = 0; i < ime.Length; i++)
{
    if (!samoglasniki.Contains(ime.ToLower()[i])) 
    {
        Console.Write(ime[i]);
    }
}
Console.WriteLine();