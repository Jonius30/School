using AufgabenverwaltungLib.Controller;
using AufgabenverwaltungLib.Models;
using AufgabenverwaltungLib.RefItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AufgabenverwaltungLib.Libraries
{
    public static class AufgabenLib
    {
        public static List<AufgabenRefItem> GetAufgabenRefItems()
        {
            AufgabenController coAufgaben = new AufgabenController();
            RollenController coRollen = new RollenController();
            UserContoller coUser = new UserContoller();

            List<Aufgabe> aufgaben = coAufgaben.GetAllAufgaben();
            List<Rolle> rollen = coRollen.GetAllRolle();
            List<User> users = coUser.GetAllUser();

            List<AufgabenRefItem> aufgabenRefItems = new List<AufgabenRefItem>();
            foreach(Aufgabe aufgabe in aufgaben)
            {
                User user = users.FirstOrDefault(x => x.Id== aufgabe.UserId) ?? new User();
                Rolle rolle = rollen.FirstOrDefault(x => x.Id == user.RollenID) ?? new Rolle();
                aufgabenRefItems.Add(new AufgabenRefItem(aufgabe, rolle, user));

            }
            return aufgabenRefItems;
        }
    }
}
