using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Models
{
    public class User : BaseModel
    {
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public int RollenID { get; set; }

        public string FullName => Vorname + " " + Nachname;

    }
}
