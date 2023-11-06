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
        //private const string PATH = "D:\\Code\\SBD211\\G\\SavesVictorines\\Victorina.json";
        private string PATH = PathForSave.YourPath();
        public void Create(Victorina victorina) // В качестве папраметра указываем ранее созданную викторину в VictorinaServiceClass
        {
            var victorines = new List<Victorina>();
            if(File.Exists(PATH))//уточнить у преподавателя: строки 17-23 ДОСТАЮТ ИНФОРМАЦИЮ ИЗ ФАЙЛА, ЕСЛИ ОН СУЩЕСТВУЕТ
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
