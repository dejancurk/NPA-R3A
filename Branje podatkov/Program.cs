Console.WriteLine("Vnesi prvo število: ");
int st1 = int.Parse(Console.ReadLine());

Console.WriteLine("Vnesi drugo število: ");
int st2 = int.Parse(Console.ReadLine());

Console.WriteLine("{0} + {1} = {2}", st1, st2, st1 + st2);



// branje podatkov s tipovnice bomo vedno realizirali tako, da bomo s tipkovnice brali vrstice, kot nize znakov (string)

/* BRANJE NIZOV z metodo ReadLine */
string ime;
Console.WriteLine("Vnesi ime:");
ime = Console.ReadLine();
Console.WriteLine("Zdravo {0}", ime);

/* BRANJE ŠTEVIL z metodo ReadLine in pretvorbo string->int */
int starost;
Console.WriteLine("Koliko si star? ");
starost = int.Parse(Console.ReadLine());
Console.WriteLine("Star si {0} let", starost);

/* BRANJE REALNIH ŠTEVIL z metodo ReadLine in pretvorbo string->double */
double teza;
Console.WriteLine("Koliko si težak? ");
teza = double.Parse(Console.ReadLine());
Console.WriteLine("Težak si {0} kg", teza);

/* BRANJE ZNAKA (char) z metodo ReadLine */
char spol;
Console.WriteLine("Vnesi spol (M/Z):");
spol = Console.ReadLine()[0]; // iz niza izluščimo prvi (in hkrati edini znak)
Console.WriteLine("Spol: {0}", spol);

Console.ReadLine();