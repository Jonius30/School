using AufgabenverwaltungLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenverwaltungLib.Controller
{
    public abstract class BaseController
    {
        public string Folder => _Folder;
        private readonly string _Folder;

        public virtual string TabName { get; }

        
        public BaseController()
        {
            _Folder = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void InsertIntoFile(string input)
        {
            StreamWriter streamWriter = new StreamWriter($"{Folder}/{TabName}.csv", true);
            streamWriter.WriteLine( input );
            streamWriter.Close();
        }

        public void UpdateFile(List<string> inputs)
        {
            StreamWriter streamWriter = new StreamWriter($"{Folder}/{TabName}.csv", false);
            foreach(string input in inputs)
            {
                streamWriter.WriteLine(input);
            }
            streamWriter.Close();        
        }

    }
}
