using OOP_Aufgaben;

// Beispielcode für die Verwendung der Klassen
Console.WriteLine("Hello World");

Konto konto = new Konto("123456789");
// Kommazahlen sind doubles die in decimal konvertiert werden müssen 
konto.Kontostand = Convert.ToDecimal(334.45);
Kunde kunde = new Kunde("Peter Lustig", "Strasse 1", konto);
Console.WriteLine($"{kunde.Name}, wohnhaft in {kunde.Adresse} hat {kunde.KundenKonto.Kontostand} auf dem Konto");

Auto auto = new Auto("VW", "Polo", 2004);
Fahrer fahrer = new Fahrer("Max Mustermann", auto);

Console.WriteLine($"Fahrer {fahrer.Name} besitzt dieses Auto {fahrer.Auto.Marke} {fahrer.Auto.Modell} aus dem Jahr {fahrer.Auto.Baujahr}");