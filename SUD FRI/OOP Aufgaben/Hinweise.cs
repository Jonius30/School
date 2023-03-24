/*
 * Hinweis 1:
 * Klassen sollten i.d.R nur private Variablen enthalten
 * 
 * Hinweis 2:
 * Klassen besitzen Eigenschaften
 * "Eigenschaften in der objektorientierten Programmierung sind Attribute, 
 * die ein Objekt beschreiben und charakterisieren. 
 * Sie können verschiedene Datentypen haben und dienen dazu, 
 * Informationen über das Objekt zu speichern(set) und abzurufen.(get)"
 * Die Eigenschaften/Properties sind in C# meisten public, damit man beispielsweise von der Oberfläche darauf zugreifen kann
 * Syntax/Beispiel:
 * objekt.Eigenschaft = ""; Hierbei wird der Setter verwendet, da der Wert zugewiesen wird
 * Console.WriteLine(objekt.Eigenschaft); Hierbei wird der Getter verwendet da ein Wert abgefragt wird
 * 
 * Hinweis 3: 
 * Strings sind nicht nullable, sie müssen immer einen Wert besitzen, sonst kann es zu Fehlermeldungen kommen.
 * Deswegen sollte man strings immer zu Beginn, d.h bei der Deklaration der Variable oder im Konstruktor einen Wert zuweisen.
 * Klassischerweise benutzt man dafür einfach einen leeren Wert, also "" oder string.Empty
 * 
 * 
 * Hinweis 4:
 * Erstellt man ein Objekt einer Klasse ist es oft sinnvoll es sofort mit Werten zu füllen oder eine Methode ausführen zu lassen 
 * Dafür gibt es Konstruktoren, da diese direkt beim Erstellen eines Objekts ausgeführt werden. Sie haben immer denselben Namen wie die Klasse selbtst
 * und können unterschiedliche Parameter beiinhalten.
 * Man kann auch mehrere Konstruktoren haben, beispielsweise wenn man je nach Situation andere Parameter benötigt
 * 
 * Hinweis 5:
 * Ebenfalls wie bei String, müssen Objekte von eigenen Klassen initialisiert werden, d.h entweder bei der Deklaration oder beim Konstruktor muss ein Wert zugewiesen werden.
 * In der Regel macht man ein leeres Objekt mit dem Schlüsselwort new()
 * Zu beachten ist: Durch new() wird immer ein Konstruktor aufgerufen, d.h man muss einen passenden Konstruktor besitzen (keine Parameter) oder die passenden Werte in die Klammer schreiben 
 * 
 * Statt einer privaten Variable und einer dazugehörigen Eigenschaft, kann man sogenannte Auto-Properties verwenden, die beides gleichzeitig erfüllen 
 * public int Zahl {get;set;}
 * Allerdings ist zu beachten, dass man hierbei die getter und setter nicht bearbeiten kann, beispielsweise Filtern von falschen Eingaben ist dabei nicht möglich
 * 
 * Hinweis 6:
 * Listen oder Arrays bieten die Möglichkeite, mehrere Objekte desselben Typs zu speicher
 * Beide müssen am Anfang initialisiert werden. Dabei wird bei der Initialisierung des Arrays die feste/maximale Größe benötigt. Listen sind dagegen "dynamisch".
 * Arrays und Listen werden in C# ab 0 indiziert, d. h an der Stelle 0 befindet sich das erste Element
 * Syntax:
 * Liste[1] = 2;
 * Console.WriteLine(Liste[1]);
 * 
 * Hinweis 7:
 * Klassen können Methoden beinhalten. Diese können von einem Objekt ausgeführt werden.
 * Die Syntax ist ähnlich der Eigenschaften
 * objekt.Methode();
 */