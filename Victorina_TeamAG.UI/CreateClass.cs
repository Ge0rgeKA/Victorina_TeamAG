using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina_TeamAG.BLL;

namespace Victorina_TeamAG.Create.UI
{
    public static class CreateClass
    {
        private static IVictorinaService _libraryService = new VictorinaServiceClass();
        public static void CreateVictorina()
        {
            Console.WriteLine("Введите название викторины:");
            string nameVictorina = Console.ReadLine();

            Console.WriteLine("Введите количество вопросов:");
            int amountquestions = Convert.ToInt32(Console.ReadLine());   
            if (amountquestions <= 0)
            {
                amountquestions = 1;
            }

            List<string> questionList = new List<string>(); // Лист вопросов
            List<string> answersList = new List<string>(); // Лист правильных ответов

            for (int questionsCount = 1; questionsCount <= amountquestions; questionsCount++)
            {
                Console.WriteLine($"Введите вопрос {questionsCount} для викторины:");
                questionList.Add(Console.ReadLine());
                Console.WriteLine("Введите правильный ответ:");
                answersList.Add(Console.ReadLine());
            }

            _libraryService.Create(nameVictorina, questionList, answersList);
        }
    }
}

