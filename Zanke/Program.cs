
//int[] stevila = new int[] { 3, 14, 15, 92, 6 };

//foreach(int stevilo in stevila)
//{
//    Console.WriteLine(stevilo);
//}

//string besedilo = "Danes je lep dan.";

//foreach(char crka in besedilo)
//{
//    Console.WriteLine(crka);

//}

//Random r = new Random();
//int en, dv, tr, st, pe, se;
//en=dv=tr=st=pe=se=0;
//for(int i = 0; i < 1000; i++)
//{
//    int met = r.Next(1, 7);
//    switch (met)
//    {
//        case 1: en++; break;
//        case 2: dv++; break;
//        case 3: tr++; break;
//        case 4: st++; break;
//        case 5: pe++; break;
//        case 6: se++; break;            
//    }  
//}
//Console.WriteLine("1: {0}", en);
//Console.WriteLine("2: {0}", dv);
//Console.WriteLine("3: {0}", tr);
//Console.WriteLine("4: {0}", st);
//Console.WriteLine("5: {0}", pe);
//Console.WriteLine("6: {0}", se);

//Random r = new Random();
//int nakljucno = r.Next(1, 101);
//int vnos = int.Parse(Console.ReadLine());
//int stPoskusov = 1;
//while (nakljucno != vnos)
//{
//    Console.WriteLine("Napačno število. Poskusi še enkrat!");
//    if (nakljucno < vnos)
//    {
//        Console.WriteLine("Tvoje število je preveliko");
//    }
//    else
//    {
//        Console.WriteLine("Tvoje število je premajhno");
//    }
//    vnos = int.Parse(Console.ReadLine());
//    stPoskusov++;
//}
//Console.WriteLine("BRAVO! Potreboval si {0} poskusov", stPoskusov);

// Naloga 3
int stevec = 0;
Random r = new Random();
int sestice = 0;

while (sestice != 2)
{
    int met = r.Next(1, 7);
    Console.WriteLine(met);
    if (met == 6)
    {
        sestice++;
    }
    else
    {
        sestice = 0;
    }
    stevec++;
 }
Console.WriteLine($"Potrebovali smo {stevec} metov");
