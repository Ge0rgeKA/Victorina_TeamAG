using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina_TeamAG.Core;
using Victorina_TeamAG.DAL;

namespace Victorina_TeamAG.BLL
{
    public class VictorinaServiceClass : IVictorinaService
    {
        private readonly IVictorinaDAL _victorinaDAL = new VictorinaDAL();

        public void CreateVictorina(string vicname, List <string> vicquestions)
        {
            var victorina = new Victorina(vicname, vicquestions);
        }
    }
}
