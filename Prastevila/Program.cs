Console.Write("Vnesi število: ");
int stevilo = int.Parse(Console.ReadLine());
bool prastevilo = true;

if ((stevilo == 1) || (stevilo % 2 == 0) && (stevilo!=2))
    prastevilo = false;
else
    for(int i = 2; i <= stevilo / 2; i++)
    {
        if (stevilo % i == 0)
        {
            prastevilo=false;
            break;
        }
    }

Console.WriteLine("Število {0} {1} praštevilo.", stevilo, (prastevilo) ? "JE" : "NI");