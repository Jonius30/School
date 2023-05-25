using AufgabenverwaltungLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Controller
{
    public class RollenController : BaseController
    {
        public override string TabName { get; } = "Rolle";
        public void InsertRolle(Rolle rolle)
        {
            string input = $"{rolle.Id};{rolle.Name}";
            InsertIntoFile(input);
        }

        public Rolle GetRolle()
        {
            return new Rolle();
        }

        public List<Rolle> GetAllRolle()
        {
            List<Rolle> list = new List<Rolle>();
            StreamReader streamReader = new StreamReader($"{Folder}\\{TabName}.csv");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split(';');
                list.Add(new Rolle()
                {
                    Id = Convert.ToInt32(values[0]),
                    Name = values[1]

                });
            }
            streamReader.Close();
            return list;
        }

        public Rolle GetNewModel(List<Rolle>? rollen = null)
        {
            rollen ??= GetAllRolle();

            int id;
            Rolle? lastRolle = rollen.OrderByDescending(a => a.Id).FirstOrDefault();
            id = lastRolle != null ? lastRolle.Id + 1 : 1;

            return new Rolle() { Id = id };

        }
    }
}
