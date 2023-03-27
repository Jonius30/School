using System.Collections.Generic;
using System.Xml.Linq;

List<int> messreihe = MessreiheErstellen();
foreach (int i in messreihe) {
    Console.Write($"[{i}], ");
}
    
List<int> sortierteMessreihe = SortierteListe(messreihe);
Console.WriteLine();

Console.WriteLine($"Maximum: {Maximum(sortierteMessreihe)}");
Console.WriteLine($"Minimum: {Minimum(sortierteMessreihe)}");
Console.WriteLine($"Median: {Median(sortierteMessreihe)}");
Console.WriteLine($"Spannweite: {Spannweite(sortierteMessreihe)}");
Console.WriteLine($"Mittlere Abweichung: {MittlereAbweichung(sortierteMessreihe)}");


// Dictionary: Ein Dictionary hat immer einen Key dem eine Value zugeordnet ist.
// Hier: Jeder Wert der vorkommt (Key) hat die Anzahl der Einträge in der Liste (Value)
Dictionary<int, int> sortierteMessreiheDictionary = new();
foreach (int i in sortierteMessreihe)
{
    // Für jeden Wert, sofern noch nicht angelegt, wird ein Eintrag demDictionary hinzugefügt(Wert, Anzahl)
    if (!sortierteMessreiheDictionary.ContainsKey(i))
    {
        sortierteMessreiheDictionary.Add(i, AnzahlAnEintraegen(sortierteMessreihe, i));
    }
}

// sortierteMessreiheDictionary.OrderByDescending(x => x.Value) sortiert die Einträge eines Dictionaries nach der Value (Hier Anzahl), OrderByDescending bedeutet dass die größten Werte an erster Stelle stehen werden
// Hier wird es daraus eine Liste gebilted um die Werte sortiert nacheinander ausgeben zu können (Das geht mit einem Dictionary nicht, da man hier nur die Werte über den Key und nicht position bekommt)
// Der Typ eines DictionaryEintrags ist KeyValuePair<typ vom key, typder value>
List<KeyValuePair<int,int>> pairs =sortierteMessreiheDictionary.OrderByDescending(x => x.Value).ToList();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Wert: {pairs[i].Key}, Anzahl {pairs[i].Value}");
}

List<int> MessreiheErstellen()
{
    List<int> result = new List<int>();
    for (int i = 0; i < 100; i++)
    {
        result.Add(new Random().Next(0, 21));
    }
    return result;
}
List<int> SortierteListe(List<int> liste)
{
    //liste.Sort sortiert die Liste liste
    liste.Sort();
    return liste;
}
int Maximum(List<int> liste)
{
    // [^1] ist das letzte Element einer liste, alternativsortierteMessreihe[sortierteMessreihe.Count-1]
    return liste[^1];
}
int Minimum(List<int> liste)
{
    return liste[0];
}
double Median(List<int> liste)
{
    double median = 0;

    // bei einer List mit gerader Anzahl wird der Median aus dem Durchschnitt der zwei mittleren Element berechnet
    if (liste.Count % 2 == 0)
    {
        // list.Count / 2 gibt bei Listen mit ungerader Anzahl genau den mittleren Index
        // Bei gerader Anzahl wird das "größere" der mitttleren mit list.Count / 2 zurückgegeben da die Zählung mit 0 beginnt.
        int zahl1 = liste[liste.Count / 2 - 1];
        int zahl2 = liste[liste.Count / 2];
        median = (zahl1 + zahl2) / 2;
    }
    // Bei ungerader Anzahl ist der Median das Element in der Mitte
    else
        median = liste[liste.Count / 2];
    return median;
}
int Spannweite(List<int> liste)
{
    return Maximum(liste) - Minimum(liste);
}
double MittlereAbweichung(List<int> liste)
{
    // Formel für MittlereAbweichung
    // mittlere Abweichung = (|x1 - durchschnitt| + |x2 - durchschnitt | + | x3 - durchschnitt | ... | xn - durchschnitt |) / Anzahl von Elementen
    
    // Durchschnitt
    double durchschnitt = liste.Sum() / liste.Count;
    // (|x1 - durchschnitt| + |x2 - durchschnitt| + |x3 - durchschnitt | ... | xn - durchschnitt |)
    double gesamteAbweichung = 0;
    foreach (int i in liste)
    {
        // Math Abs bildet den Betrag, ignoriert also das Vorzeichen
        gesamteAbweichung += Math.Abs(i - durchschnitt);
    }

    return gesamteAbweichung / liste.Count;
}
int AnzahlAnEintraegen(List<int> liste, int wert)
{
    // Es wird zurückgegeben wie oft der Wert in der Liste vorkommt
    int count = 0;
    foreach (int i in liste)
    {
        if (i == wert)
            count++;
    }
    return count;
}