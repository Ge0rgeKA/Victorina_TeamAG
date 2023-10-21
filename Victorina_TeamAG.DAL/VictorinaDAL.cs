using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Victorina_TeamAG.Core;

namespace Victorina_TeamAG.DAL
{
    public class VictorinaDAL : IVictorinaDAL
    {
        private const string PATH = "D:\\Code\\SBD211\\G\\SavesVictorines\\Victorina.json";
        public void Create(Victorina victorina)
        {
            var victorines = new List<Victorina>();
            if(File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    victorines = JsonSerializer.Deserialize<List<Victorina>>(fs); //уточнить
                }
            }

            victorines.Add(victorina);
            Write(victorines);
        }

        private void Write(List<Victorina> victorina)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Victorina>>(fs, victorina);
            }
        }
    }
}
