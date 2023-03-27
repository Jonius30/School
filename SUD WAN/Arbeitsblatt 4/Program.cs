AufgabeSechs();

void AufgabeEins()
{
    Console.WriteLine("Aufgabe 1");
    int zahl1 = IntAusKonsole("Bitte erste Zahl eingeben", "Ungültige Eingabe, Bitte eine ganzzahlige Zahl angeben");
    int zahl2 = IntAusKonsole("Bitte zwiete Zahl eingeben", "Ungültige Eingabe, Bitte eine ganzzahlige Zahl angeben");

    // Der typ int gibt das ein ganzzahliges Ergebnis zurück, der Rest wird verworfen, es wird NICHT gerundet
    int ergebnisOhneRest = zahl1 / zahl2;

    // Rechnet man die erste Zahl minus das Ergbenis mal die zweite Zahl erhält man den Rest
    int modulo = zahl1 - (ergebnisOhneRest * zahl2);

    Console.WriteLine("Modulo = " + modulo);
    Console.WriteLine();
}

void AufgabeZwei()
{
    Console.WriteLine("Aufgabe 2");

    // float[] ist ein Array, kann mehrere Werte des typs float speichern.
    // Mit new float[3] wird das Array initialisiert, das Array hat 3 Elemente
    // Bei Arrays muss die Gesamtgröße direkt bei initialisieren angegeben werden
    float[] zahlen = new float[3];

    // Arrays werden mit 0 indiziert. Dass bedeutet an der Stelle zahlen[0] befindet sich das erste Objekt
    zahlen[0] = FLoatAusKonsole("Bitte Zahl eingeben", "Keine gültige Eingabe");
    zahlen[1] = FLoatAusKonsole("Bitte Zahl eingeben", "Keine gültige Eingabe");
    zahlen[2] = FLoatAusKonsole("Bitte Zahl eingeben", "Keine gültige Eingabe");

    // Array.Sort sortiert dass ganze Array, bei Zahlen(int, double, float) wird hierbei nach größe sortiert
    Array.Sort(zahlen);

    // Nach der Sortierung ist die kleinste Zahl an der ersten Stelle 
    // Die größte Zahl ist an der letzten Stelle, Bedeutet die Gesamtanzahl von Elementen - 1, da ab 0 gezählt wird
    Console.Write("Kleinste Zahl: " + zahlen[0]);
    Console.WriteLine("Größte Zahl" + zahlen[zahlen.Length - 1]);

    Console.WriteLine();
}

void AufgabeDrei()
{
    int tag = IntAusKonsole("Bitte Tag als eingeben", "Ungültig, bitte eine Zahl eingeben");
    int monat = IntAusKonsole("Bitte Monat als Zahl eingeben", "Ungültig, bitte eine Zahl eingeben");
    int jahr = IntAusKonsole("Bitte das Jahr eingeben", "Ungültig, bitte eine Zahl eingeben");

    // bool wird auf true gesetzt wenn alle Kriterien erfüllt werden
    bool isDatum = false;

    // Überprüfung Schaltjahr, wird auf true gesetzt wenn alle Kriterien erfüllt sind
    bool isSchaltjahr = false;
    // Überprüfung ob durch 4 teilbar
    if(jahr % 4 == 0)
    {
        //  ein Jahr, das ohne Rest durch 100 teilbar ist (z. B. 1900), nur dann ein Schaltjahr ist, wenn es auch durch 400 teilbar ist.
        // Ist das Jahr durch 4 teilbar aber nicht durch hundert ist es automatisch ein Schaltjahr, Programm spring in den else Block 
        if (jahr % 100 == 0)
        {
            // Da die variable standartmäßig auf false ist, ist ein else-Block nicht nötig
            if(jahr % 400 == 0)
            {
                isSchaltjahr=true;
            }
        }
        else
        {
            isSchaltjahr=true;
        }
    }
    if(jahr >= 0)
    {
        // && logisches UND, beide Sachen müssen eintreffen
        if(monat > 0 && monat <= 12)
        {
            // switch: Hat der Wert einen Wert/Case der unten definiert wird, wird der Code in den geschweiften Klammern ausgeführt
            // jeder Case benötigt ein sogenanntes break; damit wird der Switch verlassen
            switch (monat)
            {
                // Hat ein monat einen hier erwähnten case, also ist der Wert 1,3,4,7,8,10 oder 12 wird der Code ausgeführt 
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    {
                        // Befindet sich im if statement nur eine Zeile, braucht man die geschweiften Klammern nicht
                        if (tag == 31)
                            isDatum = true;

                        break;
                    }
                case 2:
                    {
                        if (isSchaltjahr)
                        {
                             
                            if (tag == 29)
                                isDatum = true;
                        }
                        else
                        {
                            if (tag == 28)
                                isDatum = true;
                        }
                        break;
                    }
                case 4: case 6: case 9: case 11:
                    {
                        if(tag == 30)
                            isDatum = true;
                        break;
                    }
            }
        }
    }
    if (isDatum)
    {
        Console.WriteLine("Das Datum ist korrekt");
    }
    else
    {
        Console.WriteLine("Das Datum ist nicht korrekt");
    }
    Console.WriteLine();
    
}

void AufgabeVier()
{
    // new Random().Next generiert zufällige eine Zahl, in den Klammern wird der Bereich angegeben 
    // Zu beachten ist. Der kleinst Wert ist gleich dem Wert in der Klammer. Der größte Wert ist kleiner als der Wert in der Klammer
    // Bedeutet hier werte von 1-100
    int x = new Random().Next(1,101);

    bool isErraten = false;
    do
    {
        int zahl = IntAusKonsole("Bitte Zahl eingeben", "Ungültig");
        if (zahl < x)
            Console.WriteLine("Die gesuchte Zahl ist größer");
        if(zahl > x)
            Console.WriteLine("Die gesuchte Zahl ist kleiner");
        if(zahl == x)
        {
            isErraten = true;
            Console.WriteLine("Glückwunsch");
        }

    } while (!isErraten);
}

void AufgabeFuenf()
{
    int zahl = IntAusKonsole("Bitte Zahl eingeben", "Ungültig");

    // Der Operator << verschiebt die Bits nach links hier 1 mal nach link (Bedeutet zahl wir x2 gerechnet)
    Console.WriteLine($"{zahl} * 2 = {zahl << 1}");

    // 2^2 = 4
    Console.WriteLine($"{zahl} * 4 = {zahl << 2}");

    // 2^5 = 32
    Console.WriteLine($"{zahl} * 32 = {zahl << 5}");
}

void AufgabeSechs()
{
    // Variablen
    string passwort = "ZAAHL";
    // string.ToUpper macht alle Buchstaben zu Großbuchstaben
    passwort = passwort.ToUpper();
    // char[] ist ein Array/Feld von einzelnen Zeichen. ToCharArray splittet einen string in einzelne Zeichen
    char[] passwortZeichen = passwort.ToCharArray();
    bool isEingeloggt = false;

    // Der User hat 3 Versuche, Die for.schleife ist die beste Wahl, da, solange die Versuche größer gleich 1 sind soll ein Vorgang gestartet werden und nach jedem durchlauf die Versuche um 1 reduziert werden soll
    for (int versuche = 3; versuche >= 1; versuche--)
    {
        Console.WriteLine("Bitte einloggen: " + versuche + " Versuche übrig");

        // Hier muss der TypList gewählt werden, weil die Anzahl der Zeichen dynamisch ist, entsprechen der Länge des Passworts
        // Methode Login gibt eine Liste mit dem typen char zurück
        List<char> eingebeneZeichen = Login(passwort.Length);
        // Methode CheckPasswort gibt einen bool zurück, stimmen die Zeichen wird true zurückgegeben und der if-Block wird ausgeführt

        if (CheckPasswort(eingebeneZeichen, passwortZeichen))
        {
            // break unterbricht sofort die forschleife, und verlässt diese), auch wenn die Bedingung noch erfüllt sind,
            // somit wird beim erflogreichen Login kein neuer Versuch gestartet auch wenn der Benutzer noch Versuche hat.
            isEingeloggt = true;
            break;
        }
    }
    // Ausgabe ob Login erfolgreich war, entweder nach erflogreichen ogin(break) oder nach Ablauf der forschleife (Versuche < 1)
    if (isEingeloggt)
    {
        Console.WriteLine("LOGIN korrekt");
    }
    else
    {
        Console.WriteLine("Login abgebrochen");
    }
}

bool CheckPasswort(List<char> eingebeneZeichen, char[] passwortZeichen)
{
    // foreach schleife, geht jedes eingegebene Zeichen durch
    foreach (char c in eingebeneZeichen)
    {
        bool validChar = false;
        // Diese schleife geht durch jedes Zeichen vom Passwort durch
        for (int i = 0; i < passwortZeichen.Length; i++)
        {
            // Wurde an der Stelle i im Passwort das eingegebene Zeichen gefunden
            if (passwortZeichen[i] == c)
            {
                // Wird valid char auf true gesetzt, weil es ein richtiges Zeichen ist
                validChar = true;

                // Das zeichen muss aus dem Feld passwortZeichen gelöscht werden und die Forschleife muss unterbrochen werden
                // Sonst kommt es bei doppelten Zeichen zu Fehlern
                // Ohne diesen vorgang wäre das Passwort richtig  der User 4 mal dasselbe Zeichen eingeben würde,  wenn dies nur einmal im passwort vorhanden ist
                Array.Clear(passwortZeichen, i, 1);
                break;
            }
        }
        if (!validChar)
            // Sobald ein Zeichen nicht vorhanden ist kann sofort Überprüfung beendet werden, da das Pw nicht richtig kann
            return false;
    }
    // Wurde jedes einzelne Zeichen gefunden kann true returned werden
    return true;
}
// Parameter zeichenAnzahl = Länge des Passworts
List<char> Login(int zeichenAnzahl)
{
    // Liste wird initialisiert als neue leere Liste
    List<char> eingebeneZeichen = new List<char>();
    for (int i = 0; i < zeichenAnzahl; i++)
    {
        // Es wird nach Zeichen gefragt, abhängig von der Länge des Passworts
        // char.ToUpper() macht aus einem Buchstaben einen Großbuchstaben
        // char.ToUpper() hat als parameter einen Char, die Methode CharsAusKonsole liefert einen char zurück, kann also direkt in die Klammer geschrieben werden
        eingebeneZeichen.Add(char.ToUpper(CharAusKonsole($"Bitte Zeichen { i + 1} eingeben", "Ungültig")));
    }
    return eingebeneZeichen;
}
char CharAusKonsole(string nachricht, string fehlermeldung)
{
    char zeichen;
    bool isValid = false;
    // do-while Schleife, der Code wird immer einmal ausgeführt, danach wird die Bedingung, geprüft.
    // Ist diese erfüllt wiederholt sich der Vorgang, solange bis Bedingung nicht erfüllt wird
    do
    {
        Console.WriteLine(nachricht);
        if (char.TryParse(Console.ReadLine(), out zeichen))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine(fehlermeldung);
        }
        // !isValid bedeutet isValid == false
    } while (!isValid);
    return zeichen;
}

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
float FLoatAusKonsole(string nachricht, string fehlermeldung)
{
    float zahl;
    bool isValid = false;

    // do-while Schleife, der Code wird immer einmal ausgeführt, danach wird die Bedingung, geprüft.
    // Ist diese erfüllt wiederholt sich der Vorgang, solange bis die Bedingung nicht erfüllt wird
    do
    {
        Console.WriteLine(nachricht);
        if (float.TryParse(Console.ReadLine(), out zahl))
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
