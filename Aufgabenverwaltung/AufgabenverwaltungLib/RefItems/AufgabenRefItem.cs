using AufgabenverwaltungLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.RefItems
{
    public class AufgabenRefItem
    {
        public Aufgabe Aufgabe { get; set; } = new Aufgabe();
        public Rolle Rolle { get; set; } = new Rolle();
        
        public User? User { get; set; }

        public AufgabenRefItem() { }

        public AufgabenRefItem(Aufgabe aufgabe, Rolle rolle, User user)
        {
            Aufgabe = aufgabe;
            Rolle = rolle;  
            User = user;
        }
    }
}
