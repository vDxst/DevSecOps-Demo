using System;

namespace DevSecOpsCSharpDemo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dieses Programm zeigt den Unterschied zwischen");
        Console.WriteLine("einer unsicheren SQL-Abfrage und einer sicheren Variante.");
        Console.WriteLine();

        Console.Write("Bitte User-ID eingeben (1 OR 1=1)");
        string input = Console.ReadLine() ?? "";


        Console.WriteLine();
        Console.WriteLine();


        //Unsafe Query
        string query1 = "SELECT * FROM Users WHERE ID = " + input;
        Console.WriteLine("[UNSICHER]");
        Console.WriteLine("Die Benutzereingabe wird direkt in den SQL-Befehl eingefügt:");
        Console.WriteLine(query1);
        Console.WriteLine();
        Console.WriteLine("Problem:");
        Console.WriteLine("Wenn ein Angreifer SQL-Code eingibt, wird daraus Teil der Abfrage.");
        Console.WriteLine("Beispiel: Aus der Eingabe '1 OR 1=1' wird eine manipulierte Query.");


        Console.WriteLine();
        Console.WriteLine();


        //Safe Query
        string query2 = "SELECT * FROM Users WHERE ID = @id";
        Console.WriteLine("[SICHER]");
        Console.WriteLine("Der SQL-Befehl nutzt einen festen Platzhalter:");
        Console.WriteLine(query2);
        Console.WriteLine();
        Console.WriteLine("Parameter:");
        Console.WriteLine($"@id = \"{input}\"");
        Console.WriteLine();
        Console.WriteLine("Vorteil:");
        Console.WriteLine("Die Eingabe wird nur als Wert behandelt und nicht als SQL-Code ausgeführt.");


        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Fazit:");
        Console.WriteLine("Unsichere Variante: User-Input wird direkt in SQL eingebaut.");
        Console.WriteLine("Sichere Variante: User-Input wird getrennt als Parameter behandelt.");
    }
}
