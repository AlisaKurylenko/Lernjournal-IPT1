int amount;
do
{
    Console.WriteLine("Anzahl Bücher: ");
    amount = int.Parse(Console.ReadLine());
} while (amount < 1 || amount > 5);
for (int i = 1; i <= amount; i++)
{
    Console.WriteLine("Buch " + i + " registriert");
}
while (amount >= 0)
{
    Console.WriteLine("Noch " + amount + " offen");
    amount--;
}
Console.WriteLine("Alle Bücher verarbeitet.");
