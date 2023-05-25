using AufgabenverwaltungLib.Models;
using AufgabenverwaltungLib.RefItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Controller
{
    public class AufgabenController : BaseController
    {
        public override string TabName { get; } = "Aufgabe"; 
        public void InsertAufgabe(Aufgabe aufgabe)
        {
            string input = $"{aufgabe.Id};{aufgabe.Bezeichnung};{aufgabe.Beschreibung};{aufgabe.UserId};{aufgabe.ZustandId}";
            InsertIntoFile(input);
        }

        public Aufgabe? GetAufgabeByID(int id, List<Aufgabe>? list = null)
        {
            list ??= GetAllAufgaben();

            Aufgabe? aufgabe = list.FirstOrDefault(a => a.Id == id);
            return aufgabe;
        }

        public void UpdateAufgabenToFile(List<Aufgabe> aufgabes)
        {
            List<string> list = new List<string>();
            foreach(Aufgabe aufgabe in aufgabes)
            {
                list.Add($"{aufgabe.Id};{aufgabe.Bezeichnung};{aufgabe.Beschreibung};{aufgabe.UserId};{aufgabe.ZustandId}");
            }
            UpdateFile(list);
        }

        public void UpdateAufgabe(Aufgabe aufgabe)
        {
            List<Aufgabe> aufgaben = GetAllAufgaben();
            foreach(Aufgabe moAufgabe in aufgaben)
            {
                if (moAufgabe.Id == aufgabe.Id)
                {
                    moAufgabe.Bezeichnung = aufgabe.Bezeichnung;
                    moAufgabe.Beschreibung = aufgabe.Beschreibung;
                    moAufgabe.UserId = aufgabe.UserId;
                    moAufgabe.ZustandId = aufgabe.ZustandId;
                }

            }
            UpdateAufgabenToFile(aufgaben);
        }



        public List<Aufgabe> GetAllAufgaben()
        {
            List<Aufgabe> list = new List<Aufgabe>();
            StreamReader streamReader = new StreamReader($"{Folder}\\{TabName}.csv");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] values = line.Split(';');
                list.Add(new Aufgabe()
                {
                    Id = Convert.ToInt32(values[0]),
                    Bezeichnung = values[1],
                    Beschreibung = values[2],
                    UserId = Convert.ToInt32(values[3]),
                    ZustandId = Convert.ToInt32(values[4]),

                });
            }
            streamReader.Close();
           return list;
        }

        public Aufgabe GetNewModel(List<Aufgabe>? aufgaben = null)
        {
            aufgaben ??= GetAllAufgaben();

            int id;
            Aufgabe? lastAufgabe = aufgaben.OrderByDescending(a => a.Id).FirstOrDefault();
            id = lastAufgabe != null ? lastAufgabe.Id + 1 : 1;

            return new Aufgabe() { Id = id };

        }

        public Aufgabe SetNewAufgabe(string bezeichnung, string beschreibung, int userId, int zustandId)
        {
            Aufgabe aufgabe = GetNewModel();
            aufgabe.Bezeichnung = bezeichnung;
            aufgabe.Beschreibung = beschreibung;
            aufgabe.UserId = userId;
            aufgabe.ZustandId = zustandId;
            return aufgabe;
        }
        
    }
}
