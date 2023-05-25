using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Models
{
    public class Aufgabe : BaseModel
    {
        public string Bezeichnung { get; set; } = string.Empty;

        public string Beschreibung { get; set; } = string.Empty;

        public int UserId { get; set; }

        public int ZustandId { get; set; }

       
    }
}
