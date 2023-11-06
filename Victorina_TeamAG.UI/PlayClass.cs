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
        public static int ChooseVictorina()
        {
            List<Victorina> victorinas = ReturnListVictorines();
            Console.WriteLine("Выберте викторину для игры");
            foreach (var victorina in victorinas)
            {
                Console.WriteLine($"{victorinas.IndexOf(victorina) + 1}. {victorina.VictorinaName}");
            }
            Console.Write("Ваш выбор: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            while (userChoise > victorinas.Count() || userChoise <= 0)
            {
                Console.WriteLine("Вы ввели номер за диапазоном имеющихся викторин");
                Console.Write("Попробуйте снова: ");
                userChoise = Convert.ToInt32(Console.ReadLine());
            }

            int VictrorinaIndex = userChoise - 1;
            return VictrorinaIndex;

        }
        public static void PlayVictorina(int victrorinaIndex)
        {
            List<Victorina> victorinas = ReturnListVictorines();
            Console.WriteLine($"Название викторины {victorinas[victrorinaIndex].VictorinaName}");

            //foreach (Victorina victorina in victorinas)
            //{
                foreach (string question in victorinas[victrorinaIndex].Questions)
                {
                    int indexOfQuestion = victorinas[victrorinaIndex].Questions.IndexOf(question);
                    Console.WriteLine($"{indexOfQuestion + 1}) {question}"); //вывод вопроса на экран с его номером - НЕ ИНДЕКСОМ

                    for (int i = indexOfQuestion * 3, nA = 1; i < indexOfQuestion * 3 + 3; i++, nA++) //индекс ответов (a) для nA вопроса начинается с nA*n, где nA - индекс вопроса, n - количество ответов в викторине; условие: i < nA+3
                    {
                        Console.WriteLine($"{nA}. {victorinas[victrorinaIndex].Answers[i]}");
                    }

                    Console.Write("Ваш ответ: ");
                    int answer = Convert.ToInt32(Console.ReadLine());

                    if(answer == victorinas[victrorinaIndex].IndexOfRightAnswer[indexOfQuestion])
                    {
                        Console.WriteLine("Ваш ответ верный!\n");
                    }
                    else
                    {
                        //Console.WriteLine($"Правильный ответ: {victorina.Answers[victorina.IndexOfRightAnswer[indexOfQuestion]]}\n");
                        Console.WriteLine($"Правильный ответ: {victorinas[victrorinaIndex].IndexOfRightAnswer[indexOfQuestion]}\n");
                    }
               // }
            }
        }

        public static List<Victorina> ReturnListVictorines()
        {
            //const string PATH = "D:\\Code\\SBD211\\G\\SavesVictorines\\Victorina.json";
            string PATH = PathForSave.YourPath();
            var victorines = new List<Victorina>();
            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    victorines = JsonSerializer.Deserialize<List<Victorina>>(fs);
                }
            }
            return victorines;  
        }
    }
}
