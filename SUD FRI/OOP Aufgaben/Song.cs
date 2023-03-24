namespace OOP_Aufgaben
{
    public class Song
    {
        // Hinweis 6
        public string Titel { get; set; }

        public double Spieldauer { get; set;}


        // Konstruktoren Hinweis 4
        public Song()
        {
            // Hinweis 3
            Titel= string.Empty;
        }

        public Song(string titel, double spieldauer)
        {
            Titel = titel;
            Spieldauer = spieldauer;
        }
    }
}
