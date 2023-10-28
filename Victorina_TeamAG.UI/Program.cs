using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina_TeamAG.UI;
using Victorina_TeamAG.Create.UI;



//﻿using ConsoleLibray.UI.Models.Enums;
//using ConsoleLibray.UI.UI;

bool isRun = true;

while (isRun)
{
    Console.WriteLine("Добро пожаловать в викторину городов, введите вопросы о городах:");
    Console.WriteLine("1 - Создать викторину");
    Console.WriteLine("2 - Учавствовать в викторине");
    Console.WriteLine("4 - Очистить консоль");
    Console.WriteLine("5 - Выйти из приложения");

    OurEnumClass userInput;
    try
    {
        userInput = (OurEnumClass)Convert.ToInt32(Console.ReadLine());

    }
    catch
    {
        Console.Clear();
        continue;
    }

    switch (userInput)
    {
        case OurEnumClass.Create:
            CreateClass.CreateVictorina();
            break;
        case OurEnumClass.Play:
            PlayClass.Playing();
            break;
        case OurEnumClass.Clear:
            Console.Clear();
            break;
        case OurEnumClass.Exit:
            isRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Неизвестная enum");
            Console.WriteLine();
            break;
    }
}