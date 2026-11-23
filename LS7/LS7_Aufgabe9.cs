int auswahl; do
{
Console.Write("Wähle 1, 2 oder 3: ");
auswahl = Convert.ToInt32(Console.ReadLine());
} while (auswahl < 1 || auswahl > 3); Console.WriteLine("Auswahl gespeichert.");
