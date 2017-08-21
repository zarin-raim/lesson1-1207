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
            //Console.WriteLine("Введите имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите фамилию: ");
            //string lastname = Console.ReadLine();
            //Console.WriteLine(name + " " + lastname);

            Console.WriteLine("Введите первое число: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num2 = Int32.Parse(Console.ReadLine());

            int res = num1 + num2;
            Console.WriteLine("Сумма введенных чисел: " + res);
            

            Console.ReadLine();
        }
    }
}
