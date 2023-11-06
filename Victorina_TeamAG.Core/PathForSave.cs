using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Victorina_TeamAG.Core
{
    public class PathForSave //класс с 1 методом, который возвращает путь для сохранения файла, чтобы не менять его везде, а только здесь
    {
        private const string PATH = "D:\\NEwSavesTest\\Victorina.json";
            //"D:\\SBD211\\Anton\\SavesVictorines\\Victorina.json";


        public static string YourPath()
        {
            return PATH;
        }
    }
}
