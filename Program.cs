Console.Title = "Zahlenraten-Spiel";
Console.WriteLine("Willkommen zum Zahlenraten-Spiel!");
Console.WriteLine("Wie heisst du?");  //Fragt den Spieler nach seinem Namen
string name = Console.ReadLine();
Console.WriteLine("Hallo " + name + "!");


while (true)
{


    Random zufallsgenerator = new Random();
    int geheimzahl = zufallsgenerator.Next(1, 101);
    int maximaleVersuche = 10;

    Console.WriteLine("Welchen Schwierigkeitsgrad möchtest du?"); //Fragt den Spieler nach dem Schwierigkeitsgrad
    Console.WriteLine("    1. Einfach (1-100)"); //Gibt die Schwierigkeitsgrade aus
    Console.WriteLine("    2. Mittel (1-500)");  
    Console.WriteLine("    3. Schwer (1-1000)");
    Console.WriteLine("    4. Hardcore (1-100 1 Versuch)");
    Console.WriteLine(new string('=', 40));
    string schwierigkeit = Console.ReadLine();


    while (schwierigkeit != "1" && schwierigkeit != "2" && schwierigkeit != "3" && schwierigkeit != "4")
    {
        Console.WriteLine("Ungültige Auswahl. Wählen Sie eine gültige Auswahl."); //Überprüft, ob die Eingabe des Spielers gültig ist
        schwierigkeit = Console.ReadLine();
    }

    switch (schwierigkeit)
    {
        case "1":
            Console.WriteLine("Einfach ausgewählt."); //Setzt die maximale Anzahl an Versuchen auf 10 und generiert eine Zufallszahl zwischen 1 und 100
            geheimzahl = zufallsgenerator.Next(1, 101);
            break;

        case "2":
            Console.WriteLine("Mittel ausgewählt."); //Setzt die maximale Anzahl an Versuchen auf 10 und generiert eine Zufallszahl zwischen 1 und 500
            geheimzahl = zufallsgenerator.Next(1, 501);
            break;

        case "3":
            Console.WriteLine("Schwer ausgewählt."); //Setzt die maximale Anzahl an Versuchen auf 10 und generiert eine Zufallszahl zwischen 1 und 1000
            geheimzahl = zufallsgenerator.Next(1, 1001);
            break;
        case "4":
            Console.WriteLine("Hardcore ausgewählt."); //Setzt die maximale Anzahl an Versuchen auf 1 und generiert eine Zufallszahl zwischen 1 und 100
            geheimzahl = zufallsgenerator.Next(1, 101);
            maximaleVersuche = 1;
            break;
    }

    Console.WriteLine("Ich habe mir eine Zahl ausgedacht. Versuche sie zu erraten."); //Gibt die maximale Anzahl an Versuchen aus

    bool erraten = false;
    int versuche = 0;
    int uebrige_versuche = maximaleVersuche - versuche;



    while (!erraten && versuche < maximaleVersuche)
    {
        Console.WriteLine("Du hast noch " + uebrige_versuche + " Versuche.");
        Console.WriteLine("Dein Versuch: ");
        Console.Write("      "); 

        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int tipp))
        {
            versuche++;
            uebrige_versuche = maximaleVersuche - versuche; //Berechnet die verbleibenden Versuche, indem die Anzahl der Versuche von der maximalen Anzahl an Versuchen subtrahiert wird

            if (tipp < geheimzahl)
            {
                Console.WriteLine("Zu niedrig.");
            }
            else if (tipp > geheimzahl)
            {
                Console.WriteLine("Zu hoch.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Richtig!");
                Console.ResetColor();
                erraten = true;
                Console.WriteLine("Du hast " + versuche + " Versuche gebraucht."); //Gibt die Anzahl der Versuche aus, die der Spieler benötigt hat, um die Zahl zu erraten
            }
        }
        else
        {
            Console.WriteLine("Bitte eine Zahl eingeben.");
        }
    }

    if (!erraten)
    {
        Console.WriteLine("Leider verloren. Die Zahl war: " + geheimzahl);
    }
    Console.WriteLine("Nochmal spielen?"); 
    string antwort = Console.ReadLine().ToLower();
    if (antwort == "ja")
    {
        Console.Clear();
    }
    else if (antwort == "nein") //Beendet das Spiel, wenn der Spieler "nein" eingibt
    {
        Console.Clear(); Console.WriteLine("Schade, vielleicht ein anderes Mal.");
        break;
    }
    else { Console.WriteLine("Ungültige Eingabe. Bitte 'ja' oder 'nein' eingeben."); //Überprüft, ob die Eingabe des Spielers gültig ist
    }  
}
