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

        public void Create(string vicname, List <string> vicquestions, List<string> vicanswers, List<int> rightAnswer)
        {
            var victorina = new Victorina(vicname, vicquestions, vicanswers, rightAnswer);
            _victorinaDAL.Create(victorina);
        }
    }
}
