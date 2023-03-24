using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Aufgaben
{
    public class Fahrer
    {
        // Variablen Hinweis 1
        private string _Name = string.Empty;
        // Hinweis 5
        private Auto _Auto = new Auto();


        // Eigenschaften Hinweis 2
        public string Name 
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Auto Auto
        {
            get { return _Auto; }
            set { _Auto = value; }
        }


        // Konstruktoren Hinweis 4
        public Fahrer(string name)
        {
            Name = name;
        }

        public Fahrer(string name, Auto auto)
        {
            Name = name;
            Auto = auto;
        }
    }
}
