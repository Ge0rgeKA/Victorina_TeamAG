using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_TeamAG.UI
{
    public class CheckEmptyOrNumOrString <T>//класс, который будет проверять: 1) ввел ли пользователь что-нибудь; 2) является ли введенное значение числом?
    {//не удалось реализовать 
        public T GProp { get; set; }
        public static string CheckEmptyOrNumOrStringMethod (string userEnter, string phrase)
        {
            while (CheckEmpty(userEnter)) // если строка пустая, то цикл запускается заново
            {
                Console.WriteLine(phrase);
                userEnter = Console.ReadLine();
                Console.Clear();
            }
            return userEnter;
        }

        public static bool CheckEmpty(string userEnter) //Наш метод, который проверяет пустая строка или нет?
        {
            if (String.IsNullOrEmpty(userEnter)) //Метод String, который проверяет пуста ли строка или нет; если пуста, то возвращает true, иначе false
            {
                Console.WriteLine("Вы ничего не ввели!");
                Console.WriteLine("Попробуйсте снова!");
                return true; //строка пустая
            }
            else
            {
                return false;   
            }
        }

        public static int CheckNumber(string userEnter) //Наш метод, который проверяет ввведено число или текст - должно быть целое число!
        {
            int num = 0;
            while (!int.TryParse(userEnter, out num))
            {
                Console.WriteLine("Вы ввели не целочисленное значение!");
                Console.WriteLine("Попробуйте снова:");
                userEnter = Console.ReadLine();
                //Console.Clear(); - нужно найти функцию очистки нескольких строк а не всей консоли
            }
            return num;
        }

    }
}
