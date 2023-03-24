namespace OOP_Aufgaben
{
    public class Hotel
    {
        // Variablen
        private string _Name = string.Empty;
        private int _Stars = 0;

        // Eigenschaften 
        public string Name
        {
            // Lamba expression, verkürzte schreibweise für { return _Name}
            get => _Name;
            set => _Name = value;
        }
        public int Stars
        {
            get => _Stars;
            set => _Stars = value;
        }

        public List<Room> Rooms { get; set; } = new List<Room>();


        // Konstruktoren 
        public Hotel(string name, int stars)
        {
            Name = name;
            Stars = stars;
        }

        public Hotel(string name, int stars, List<Room> rooms)
        {
            Name = name;
            Rooms = rooms;
            Stars = stars;
        }

        // Methoden 

        public int CheckIn()
        {
            // foreach, jedes Element wird nacheinander betrachtet
            // Für jedes objekt room des Typs Room dass sich in der Liste Rooms befindet gilt {}
            foreach (Room room in Rooms)
            {
                if (room.IsAvailable)
                {
                    // Wird durch false auf belegt gesetzt
                    room.IsAvailable = false;

                    // Zimmer nummer wird zrückgegeben 
                    return room.Id;
                }
            }
            // Wurde in der ganzen Liste kein freier Raum gefunden wird 0 zurückgegeben
            return 0;
        }

        public void CheckOut(int roomNumber)
        {
            // foreach, jedes Element wird nacheinander betrachtet
            // Für jedes objekt room des Typs Room dass sich in der Liste Rooms befindet gilt {}
            foreach (Room room in Rooms)
            {
                
                // Wenn die Id des Rooms gleich des Parameters ist 
                if (room.Id == roomNumber)
                {
                    // Wenn der Raum belegt ist
                    if(room.IsAvailable == false)
                    {
                        // Raum wird freigemacht
                        room.IsAvailable = true;
                    }
                }
            }
        }
    }
}
