TeilaufgabeEins();
TeilaufgabeZwei();
TeilaufgabeDrei();
AufgabeEins();
AufgabeZwei();
AufgabeDrei();
AufgabeVier();
Console.ReadKey();


# region Teilaufgaben 
void TeilaufgabeEins()
{
    Console.WriteLine("Teilaufgabe 1:");
    // Console Write Line erzeugt eine Konsolenausgaben
    // Man kann sowohl Zeichenketten (string) eingeben wie auch andere Variablen
    Console.WriteLine("Hallo Welt");
    Console.WriteLine("Eine zweite Zeile!");
    Console.WriteLine();
}

void TeilaufgabeZwei()
{
    Console.WriteLine("Teilaufgabe 2:");
    
    int a = 4;
    int b = 5;

    // Man kann in string mit + zusammenfügen
    Console.WriteLine(a + " und " + b);

    // Mit String Interpolation kann man direkt in geschweiften Klammmern code schreiben, beispielsweise Varibalen, Operationen, Methoden
    Console.WriteLine($"{a} + {b} = {a+b}");
    Console.WriteLine($"{a} - {b} = {a-b}");

    // Bei Rechnungen wird der Orginaltyp der Variablen behalten 
    Console.WriteLine($"Int: {a} / {b} = {a/b}");

    // Man kann Rechnungen in einen Typ casten mit (typ)a/b
    Console.WriteLine($"Double: {a} / {b} = {(double)a / b}");

    Console.WriteLine($"{a} * {b} = {a*b}");

    // Modulo gibt den Restwert
    Console.WriteLine($"{a} % {b} = {a % b}");

    Console.WriteLine();
}

void TeilaufgabeDrei()
{
    Console.WriteLine("Teilaufgabe 3:");

    // Deklaration eines leeren strings;
    string name = string.Empty;
    Console.WriteLine("Hallo, bitte Namen eingeben");

    // Console.ReadLine ließt die Eingabe als string ein, wird direkt Enter gedrückt ist der Wert NULL, ein string kann aber nicht NULL sein 
    // Deswegen wird mit ?? bei NULL ein leerer string gespeichert
    name = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Hallo " + name + " bitte Zahl eingeben");
    
    // int.Tryparse gibt zwei Rückgabewerte einmal einen bool ob die Konvertierung geklappt hat
    // Bei Erfolg wird ein int zurückgegeben.
    // Man kann den Wert einem existierenden int hinzufügen oder als neue Variable definieren
    // Ist der bool = true (bei positiver Konvertierung) springt der Code in den If-Block, sonst in den else-Block (falls vorhanden)
    if(int.TryParse(Console.ReadLine(), out int a)) 
    {
        Console.WriteLine($"Zahl a = {a}");
        Console.WriteLine($"Verdoppelt = {a*2}");
    }
    else
    {
        Console.WriteLine(name + " Zahlen solltets du wohl wiederholen");
    }

    Console.WriteLine();
}

# endregion

# region Hauptaufgaben
void AufgabeEins()
{
    Console.WriteLine("Aufgabe 1");
    int a = IntAusKonsole("Bitte erste Zahl eingeben.", "Fehlerhafte eingabe, bitte erneut probieren");
    int b = IntAusKonsole("Bitte zweite Zahl eingeben.", "Fehlerhafte eingabe, bitte erneut probieren");

    Console.WriteLine(a + " und " + b);
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"Int: {a} / {b} = {a / b}");
    Console.WriteLine($"Double: {a} / {b} = {(double)a / b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    Console.WriteLine($"{a} % {b} = {a % b}");

    Console.WriteLine();
}

void AufgabeZwei()
{
    Console.WriteLine("Aufgabe 2");
    double kapital = DoubleAusKonsole("Bitte Startkapital eingeben", "Ungültige Eingabe");
    double zinsatz = DoubleAusKonsole("Bitte Zinssatz eingeben", "Ungültige Eingabe");

    // F2 Formatierung, zwei Nachkommastellen 
    // Math.Pow Potenz berechnen
    // C Formatierung Currency
    Console.WriteLine($"{kapital} * {zinsatz:F2} = {kapital*Math.Pow(zinsatz, 3):C}");
    Console.WriteLine();
}

void AufgabeDrei()
{
    Console.WriteLine("Aufgabe 3");
    Console.WriteLine("ax + b = 0");
    int a = IntAusKonsole("Bitte a eingeben.", "Fehlerhafte eingabe, bitte erneut probieren");
    int b = IntAusKonsole("Bitte b eingeben.", "Fehlerhafte eingabe, bitte erneut probieren");
    Console.WriteLine("x = " + a / -b);
    Console.WriteLine();
}

void AufgabeVier()
{
    Console.WriteLine("Aufgabe 4");
    int a = 10;
    int b = 20;
    int x;

    // Rechenregeln werten eingehalten, Klammern punkt vor strich;
    // Allerdings bleiben die typen bestehen 20 / 8 = 2, => 3 * 30 - 2 = 88
    x = 3 * (a + b) - b / 8; 
    Console.WriteLine($"a): {x}");

    // Bei a++ wird erst a verrechnet und dann plus 1 gesetzt, bei ++b wird erst b + 1 gesetzt und dann verrechnet
    x = (a++) + (++b);
    Console.WriteLine($"b): {x}");


    x = (a % b) % (b % (++a));
    Console.WriteLine($"c): {x}");


}
# endregion

// Es ist oft sinnvoll Teile des Codes in einzelne Methoden auszukapseln 
// Methoden können void sein, so wird keine Rückgabe erwartet 
// Methoden können auch was rückgeben, dann wird der Typ gesetzt, hier int
int IntAusKonsole(string nachricht, string fehlermeldung)
{
    int zahl;
    bool isValid = false;
    
    // do-while Schleife, der Code wird immer einmal ausgeführt, danach wird die Bedingung, geprüft.
    // Ist diese erfüllt wiederholt sich der Vorgang, solange bis die Bedingung nicht erfüllt wird
    do
    {
        Console.WriteLine(nachricht);
        if (int.TryParse(Console.ReadLine(), out zahl))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine(fehlermeldung);
        }
        // !isValid bedeutet isValid == false
    } while (!isValid);
    return zahl;
}

double DoubleAusKonsole(string nachricht, string fehlermeldung)
{
    double zahl;
    bool isValid = false;

    // do-while Schleife, der Code wird immer einmal ausgeführt, danach wird die Bedingung, geprüft.
    // Ist diese erfüllt wiederholt sich der Vorgang, solange bis die Bedingung nicht erfüllt wird
    do
    {
        Console.WriteLine(nachricht);
        if (double.TryParse(Console.ReadLine(), out zahl))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine(fehlermeldung);
        }
        // !isValid bedeutet isValid == false
    } while (!isValid);
    return zahl;
}
