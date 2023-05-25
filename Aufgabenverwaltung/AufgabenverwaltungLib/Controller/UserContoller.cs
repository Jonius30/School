using AufgabenverwaltungLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Controller
{
    public class UserContoller : BaseController
    {
        public override string TabName { get; } = "User";

        public void InsertUser(User user)
        {
            string input = $"{user.Id};{user.Vorname};{user.Nachname};{user.RollenID}";
        }

        public User GetUser()
        {
            return new User();
        }

        public List<User> GetAllUser()
        {
            List<User> list = new List<User>();
            StreamReader streamReader = new StreamReader($"{Folder}\\{TabName}.csv");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split(';');
                list.Add(new User()
                {
                    Id = Convert.ToInt32(values[0]),
                    Vorname = values[1],
                    Nachname = values[2],
                    RollenID = Convert.ToInt32(values[3]),

                });
            }
            streamReader.Close();
            return list;
        }

        public User GetNewModel(List<User>? users = null)
        {
            users ??= GetAllUser();

            int id;
            User? lastUser = users.OrderByDescending(a => a.Id).FirstOrDefault();
            id = lastUser != null ? lastUser.Id + 1 : 1;

            return new User() { Id = id };

        }

    }
}
