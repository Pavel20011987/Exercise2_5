﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название зимнего месяца");
            string month = Console.ReadLine();
            Console.WriteLine("Введите температуру воздуха");
            int temp = int.Parse(Console.ReadLine());

            if ((month == "Декабрь" || month == "Январь" || month == "Февраль") && temp > 0)

            {



                Console.WriteLine("Дождливая зима");



            }


            else
            {
                Console.WriteLine("Неверный ввод");

            }
        }
    }
}
