// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Lean");
Console.WriteLine("Wie heisst du?");
 string name = Console.ReadLine();
Console.WriteLine($"Hallo, {name}!");
Random zufallsgenerator = new Random();
int geheimzahl = zufallsgenerator.Next(1, 100); 
Console.WriteLine($"Debug: Die geheime Zahl ist {geheimzahl}");
bool erraten = false; while (!erraten); 