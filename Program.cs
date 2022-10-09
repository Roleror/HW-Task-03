using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите значение переменной m:");
            double m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной n:");
            double n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Результат деления с точностью до десятых {Math.Round(m / n, 1)}");
            Console.WriteLine($"Результат деления с точностью до сотых {Math.Round(m / n, 2)}");
            Console.WriteLine($"Результат деления с точностью до тысячных {Math.Round(m / n, 3)}");
            Console.ResetColor();
            Console.ReadLine();



        }
    }
}
