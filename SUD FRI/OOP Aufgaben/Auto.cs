using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Aufgaben
{
    public class Auto
    {
        // Variablen
        // Hinweise 1, 3
        private string _Marke = string.Empty;
        private string _Modell = string.Empty;
        private int _Baujahr;


        // Eigenschaften Hinweis 2
        public string Marke 
        { 
            get 
            { 
                return _Marke;
            }
            set 
            {
                _Marke = value;
            }
        }
        public string Modell
        {
            get
            {
                return _Modell;
            }
            set
            {
                _Modell = value;
            }
        }

        public int Baujahr
        {
            get
            {
                return _Baujahr;
            }
            set
            {
                _Baujahr = value;
            }
        }

        // Konstruktoren Hinweis 4
        // Leerer Konstruktor wenn keine Werte vorhanden
        public Auto()
        {

        }

        public Auto(string marke, string modell, int baujahr)
        {
            Marke = marke;
            Modell = modell;
            Baujahr = baujahr;
        }
    }
}
