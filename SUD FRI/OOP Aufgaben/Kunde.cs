namespace OOP_Aufgaben
{
    public class Kunde
    {
        // Variablen Hinweis 1
        // Hinweis 3
        private string _Name = string.Empty;
        private string _Adresse = string.Empty;
        // Hinweis 5
        private Konto _KundenKonto = new Konto();

        //Eingenschaften/Properties 
        //Hinweis 2

        public string Name 
        {
            get 
            { 
                return _Name; 
            }
            set 
            {
                _Name = value;
            }

        }

        public string Adresse 
        { 
            get
            {
                return _Adresse;
            }
            set
            {
                _Adresse = value;
            } 
        }

        public Konto KundenKonto 
        {
            get
            {
                return _KundenKonto;
            }
            set 
            {
                _KundenKonto = value;
            }
        }

        
        // Konstruktoren Hinweis 4
        // In diesem Konstruktor wird die Eigenschaft Konto, gar nicht beachtet, bedeutet das das Objekt ein leeres Konto( new Konto() ) besitzt  
        public Kunde(string name, string adresse)
        {
            Name = name;
            Adresse = adresse;
        }

        // Der zweite Konstruktor wird benötigt um dem Kunden direkt bei erstellen ein bereits existierendes Konto zuzuweisen
        public Kunde(string name, string adresse, Konto konto)
        {
            KundenKonto = konto;
        }
    }
}
