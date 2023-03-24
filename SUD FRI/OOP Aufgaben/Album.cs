namespace OOP_Aufgaben
{
    public class Album
    {
        public Kuenstler Kuenstler { get; set; }
        public string Sprache { get; set; }
        public string AlbumName { get; set; }

        // Hinweis 6
        public List<Song> Songs { get; set; } = new List<Song>();


        // Konstruktoren
        
        public Album() 
        { 
            // Hinweis 5
            Kuenstler= new Kuenstler();

            // Hinweis 3
            Sprache = string.Empty;

            AlbumName = string.Empty;
        }
        public Album(string sprache, Kuenstler kuenstler, string albumName)
        {
            Sprache = sprache;
            Kuenstler = kuenstler;
            AlbumName = albumName;
        }

        public Album(Kuenstler kuenstler, string sprache, List<Song> songs, string albumName) 
        {
            // Hinweis 3
            Kuenstler = kuenstler;
            Sprache = sprache;
            Songs = songs;
            AlbumName = albumName;
        }

        // Methoden
        // Hinweis 7

        /// <summary>
        /// Methode mit Rückgabewert string. Diesen string kann das Programm mit beispielsweise Console.WriteLine ausgeben
        /// </summary>
        /// <returns>Information über das Album</returns>
        public string PrintAlbum()
        {
            // String Interpolation. Durch das $ Zeichen kann man in geschweiften Klammern Variablen/Eigenschaften/Methoden direkt in den string inplementieren
            string ausgabe = $"Künstler: {Kuenstler}\nLand: {Kuenstler.Herkunftsland}\nAlbum: {AlbumName}\n";
            ausgabe += "------------------------------------";

            for(int i = 0; i < Songs.Count; i++)
            {
                // Für den Pc ist an der Stelle 0 das erste Lied, zur Ausgabe wird also i+1 verwendet
                ausgabe += $"\n{i+1}: {Songs[i].Titel} -- {Songs[i].Spieldauer:F2}";
            }

            return ausgabe;
        }
    }
}
