Console.WriteLine("Artikelname: "); 
string artikelname = Console.ReadLine(); 

Console.WriteLine("Einzelpreis: ");
string einzelpreis = Console.ReadLine();

decimal einzelpreisdec = decimal.Parse(einzelpreis); 

Console.WriteLine("Menge: "); 
string menge = Console.ReadLine();

int mengeint = int.Parse(menge); 

if (mengeint < 0)
{
    Console.WriteLine("Ungültige Menge");
    return;
}

Console.WriteLine("Artikelname: " + artikelname); 
Console.WriteLine("Einzelpreis: " + einzelpreisdec + " CHF");
Console.WriteLine("Menge: " + mengeint); 
decimal gesamtpreis = 0;
decimal rabatt = 0;

if (mengeint == 3 || mengeint == 4)
{
    rabatt = 10;    
}
    
else if (mengeint > 4)
{
    rabatt = 20;
}
decimal zwischenpreis = einzelpreisdec * mengeint;
decimal rabattbetrag = zwischenpreis * rabatt/100;
gesamtpreis = zwischenpreis - rabattbetrag;
Console.WriteLine("Rabat: " + rabatt + "%");
Console.WriteLine("Gesamtpreis: " + gesamtpreis + " CHF");