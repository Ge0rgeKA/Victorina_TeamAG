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
            List<string> answersList = new List<string>(); // Лист ответов
            List<int> rightAnswersList = new List<int>();

            for (int questionsCount = 1; questionsCount <= amountquestions; questionsCount++)
            {
                Console.WriteLine($"Введите вопрос {questionsCount} для викторины:");
                questionList.Add(Console.ReadLine());
                Console.WriteLine("Введите ответ 1:");
                answersList.Add(Console.ReadLine());
                Console.WriteLine("Введите ответ 2:");
                answersList.Add(Console.ReadLine());
                Console.WriteLine("Введите ответ 3:");
                answersList.Add(Console.ReadLine());
                Console.WriteLine("Введите ответ 4:");
                answersList.Add(Console.ReadLine());
                Console.WriteLine("Укажите номер правильного ответа:");
                rightAnswersList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            _libraryService.Create(nameVictorina, questionList, answersList, rightAnswersList);
        }
    }
}

