Console.WriteLine("Willkommen zum Zahlenraten-Spiel!");
Console.WriteLine("Wie heisst du?");
 string name = Console.ReadLine();
Console.WriteLine("Hallo " + name+"!");
Random zufallsgenerator = new Random();
int geheimzahl = zufallsgenerator.Next(1, 101);
Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht. Versuche sie zu erraten.");
bool erraten = false;
int versuche = 0;
int uebrige_versuche = 10;
while (!erraten && versuche < 10)  
{
    Console.WriteLine("Du hast noch " + uebrige_versuche + " Versuche.");
    Console.Write("Dein Versuch: ");
    versuche++; uebrige_versuche = 10 - versuche;
     
    string eingabe = Console.ReadLine();
    int tipp = int.Parse(eingabe);
    if (tipp < geheimzahl)
    { Console.WriteLine("Zu niedrig."); }
    else if (tipp > geheimzahl)
    { Console.WriteLine("Zu hoch."); }
    else
    {
        Console.WriteLine("Richtig!");
        erraten = true;
        Console.WriteLine("Du hast " + versuche + " Versuche gebraucht.");
    }
}
if (!erraten)
{ Console.WriteLine("Leider verloren. Die Zahl war:" + geheimzahl);}    

