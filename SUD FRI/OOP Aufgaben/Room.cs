namespace OOP_Aufgaben
{
    public class Room
    {
        private int _Id;
        private bool _IsAvailable;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public bool IsAvailable
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }

        public Room(int id)
        {
            Id = id;
            IsAvailable = true;
        }
    }
}
