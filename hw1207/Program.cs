using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string answer = "Хммм";
            int tmp;
            string exit = "";

            Console.WriteLine("Насколько простым должно быть приложение?");
            Console.WriteLine("Имитация магического шара.");
            while (exit != "0")
            {
                Console.Write("Введите вопрос:");
                Console.ReadLine();

                tmp = random.Next(1, 4);
                switch (tmp)
                {
                    case 1: answer = "Да"; break;
                    case 2: answer = "Нет"; break;
                    case 3: answer = "Возможно"; break;
                }
                Console.WriteLine("Ответ: " + answer);
                Console.WriteLine("\nПовторить? (0-выход)");
                exit = Console.ReadLine();
            }

        }
    }
}
