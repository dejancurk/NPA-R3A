string test;
test = "bla";
test = 10 < 5 ? "ponedeljek":test;

Console.WriteLine((5 == 5) ? "Ponedeljek" : "Torek");

if (5 == 5)
{
    Console.WriteLine("Ponedeljek");
}
else
{
    Console.WriteLine("Torek");
}


int stevilo = int.Parse(Console.ReadLine());

if (stevilo < 0)
    Console.WriteLine("Število {0} je manjše od 0", stevilo);


// ----------------------------------------------------------
                                                                         if (stevilo < 0)
    Console.WriteLine("Število {0} je manjše od 0", stevilo);
else 
    Console.WriteLine("Število {0} NI manjše od 0", stevilo);
                                                                         // ----------------------------------------------------------
                                                                         if (stevilo < 0) 
    Console.WriteLine("Število {0} je manjše od 0", stevilo);
else if (stevilo > 0)
    Console.WriteLine("Število {0} je večje od 0", stevilo); 
                                                                         // -----------------------------------------------------------
                                                                         if (stevilo < 0) 
    Console.WriteLine("Število {0} je manjše od 0", stevilo); 
else if (stevilo > 0) 
    Console.WriteLine("Število {0} je večje od 0", stevilo); 
else 
    Console.WriteLine("Število {0} je enako 0", stevilo);



// Primer SWITCH stavka

Console.Write("Vnesi dan tednu: ");
int dan = int.Parse(Console.ReadLine());

switch (dan)
{
    case 1:
        Console.WriteLine("Ponedeljek");
        break;
    case 2:
        Console.WriteLine("Torek");
        break;
    case 3:
        Console.WriteLine("Sreda");
        break;
    case 4:
        Console.WriteLine("Četrtek");
        break;
    case 5:
        Console.WriteLine("Petek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Nedelja");
        break;
    default:
        Console.WriteLine("Nisi vnesel števila 1-7.");
        break;
}


// Drugi primer

int mesec = int.Parse(Console.ReadLine());
int leto = int.Parse(Console.ReadLine()); 

switch (mesec)
{ 
    case 1: case 3: case 5: case 7: case 8: case 10: case 12:      
        Console.WriteLine("31"); 
        break; 
    case 4: case 6: case 9: case 11: 
        Console.WriteLine("30"); 
        break; 
    case 2: 
        if (leto % 400 == 0 || leto % 100 != 0 && leto % 4 == 0) 
            Console.WriteLine("29");
        else 
            Console.WriteLine("28"); 
        break; 
    default: 
        Console.WriteLine("Napačna št. meseca"); 
        break; 
}