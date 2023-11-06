
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter smth");
        string a = Console.ReadLine();
        if (String.IsNullOrEmpty(a))
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine($"Your Text: {a}");
        }

        int ANUM;

        while (!int.TryParse(a, out ANUM))
        {
            Console.WriteLine("Вы ввели не числовое значение!");
            Console.WriteLine("Попробуйте снова указать номер правильного овтета:");
            a = Console.ReadLine();
            Console.Clear();
        }
    }

    public class CheckEmptyOrNum //класс, который будет проверять: 1) ввел ли пользователь что-нибудь; 2) является ли введенное значение числом?
    {
        public CheckEmptyOrNum(string userEnter)
        {
            while (CheckEmpty(userEnter)) // если строка пустая, то цикл запускается заново
            {
                CheckNumber(userEnter);
            }
            CheckEmpty(userEnter);
        }

        public static bool CheckEmpty(string userEnter) //Наш метод, который проверяет пустая строка или нет?
        {
            if (String.IsNullOrEmpty(userEnter)) //Метод String, который проверяет пуста ли строка или нет; если пуста, то возвращает true, иначе false
            {
                Console.WriteLine("Вы ничего не ввели!");
                Console.WriteLine("Попробуйсте снова!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CheckNumber(string userEnter) //Наш метод, который проверяет ввведено число или текст - должно быть число!
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
