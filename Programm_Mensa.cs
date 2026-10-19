//Eingabe. Benutzer gibt Artikelname an.
Console.WriteLine("Artikelname: "); 
string artikelname = Console.ReadLine(); 

//Eingabe. Benutzer gibt Einzelpreis an.
Console.WriteLine("Einzelpreis: ");
string einzelpreis = Console.ReadLine();

//Verarbeitung. Programm waldet Variable 'string' in 'decimal' um.
decimal einzelpreisdec = decimal.Parse(einzelpreis); 

//Eingabe. Benutzer gibt Menge an.
Console.WriteLine("Menge: "); 
string menge = Console.ReadLine();

//Verarbeitung. Programm waldet Variable 'string' in 'int' um.
int mengeint = int.Parse(menge); 

//Verarbeitung. Programm rechnet Gesamtpreis.
decimal gesamtpreis = einzelpreisdec * mengeint; 

//Ausgabe. Programm gibt Artikelname an. 
Console.WriteLine("Artikelname: " + artikelname); 

//Ausgabe. Programm gibt Einzelname an. 
Console.WriteLine("Einzelpreis: " + einzelpreisdec + " CHF");

//Ausgabe. Programm gibt Menge an. 
Console.WriteLine("Menge: " + mengeint); 

//Ausgabe. Programm gibt Gesamtpreis an. 
Console.WriteLine("Gesamtpreis: " + gesamtpreis + " CHF"); 