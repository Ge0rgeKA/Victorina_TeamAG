﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_TeamAG.BLL
{
    public interface IVictorinaService
    {
        void Create(string vicname, List<string> vicquestions, List<string> vicanswers, List<int> rightAnswer);
    }
}
