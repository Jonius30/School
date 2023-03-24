namespace OOP_Aufgaben
{
    public class Kuenstler
    {
        // Hinweis 6
        public string Name { get; set; }
        public string Herkunftsland { get; set; }


        // Konstruktoren 
        public Kuenstler() 
        { 
            // Hinweis 3
            Name = string.Empty;
            Herkunftsland = string.Empty;
        }

        public Kuenstler(string name, string herkunftsland)
        {
            Name = name;
            Herkunftsland = herkunftsland;
        }
    }
}
