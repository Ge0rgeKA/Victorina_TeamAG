using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina_TeamAG.Core;
using System.Text.Json;

namespace Victorina_TeamAG.UI
{
    public static class PlayClass
    {
        public static void PlayVictorina()
        {
            List<Victorina> victorinas = ReturnListVictorines();
            Console.WriteLine($"Название викторины {victorinas[0].VictorinaName}");
            foreach (Victorina victorina in victorinas)
            {
                foreach (string question in victorina.Questions)
                {
                    Console.WriteLine($"{victorina.Questions.IndexOf(question) + 1}) {question}");
                    for (int i = victorina.Questions.IndexOf(question) + victorina.Questions.IndexOf(question); i < 4*(1+victorina.Questions.IndexOf(question)); i++)
                    {
                        Console.WriteLine($"{i+1}) {victorina.Answers[i]}");
                    }
                    Console.WriteLine("Ваш ответ:");
                    int answer = Convert.ToInt32(Console.ReadLine());

                    //if (String.Compare(victorina.Answers[victorina.Questions.IndexOf(question)], answer, StringComparison.OrdinalIgnoreCase))
                    if(answer==victorina.IndexOfRightAnswer[victorina.Questions.IndexOf(question)])
                    {
                        Console.WriteLine("Ваш ответ верный!");
                    }
                    else
                    {
                        Console.WriteLine($"Правильный ответ {victorina.Answers[victorina.IndexOfRightAnswer[victorina.Questions.IndexOf(question)]]}");
                    }
                }
            }
        }

        public static List<Victorina> ReturnListVictorines()
        {
            //const string PATH = "D:\\Code\\SBD211\\G\\SavesVictorines\\Victorina.json";
            const string PATH = "D:\\SBD211\\Anton\\SavesVictorines\\Victorina.json";
            var victorines = new List<Victorina>();
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                    victorines = JsonSerializer.Deserialize<List<Victorina>>(fs); //уточнить
            }

            return victorines;  
        }
    }
}
