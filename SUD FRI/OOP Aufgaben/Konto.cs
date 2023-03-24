namespace OOP_Aufgaben
{
    public class Konto
    {

        // Variablen Hinweis 1

        // Hinweis: Kontonummer ist eine Folge an Zeichen. Es ist keine Zahl als solches, deswegen Typ string (Int wäre auch möglich) 
        // Hinweis 3 
        private string _Kontonummer = string.Empty;  
        // Bei Geldbeträgen, insbesondere Rechnungen kann es zu Ungenauigkeiten beim Typ float/double kommen, deswegen decimal
        private decimal _Kontostand = 0;

        // Properties/Eigenschaften Hinweis 2
        public string Kontonummer 
        { 
            get 
            { 
                return _Kontonummer;
            } 
            set 
            { 
                if(value.All(char.IsDigit))
                    _Kontonummer = value;
            } 
        }

        public decimal Kontostand
        {
            get 
            { 
                return _Kontostand; 
            }
            set 
            { 
                _Kontostand = value; 
            }
        }

        // Konstruktoren
        // Hinweis 4
        
        // Leerer Konstuktor, falls man beim Erstellen keine Werte setzen möchte, also ein leeres Konto ohne Kontonummer
        public Konto()
        {

        }
        
        // Konstruktor, bei dem die Kontonummer beim Erstellen des Objekts angegben werden muss
        public Konto(string kontonummer)
        {
            Kontonummer = kontonummer;
        }

        // Konstruktor, bei dem die Kontonummer und Kontostand angegeben werden müssen

        public Konto(string kontonummer, decimal kontostand)
        {
           Kontonummer = kontonummer;
           Kontostand = kontostand;
        }
    }
}
