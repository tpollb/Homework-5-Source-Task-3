using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace Homework_5_Source_Task_3
{
    class Program
    {
        static string RemoveDuplicates(string s) => Regex.Replace(s, @"(.)\1+", "$1");
        static string IsUpper(string s)
        {
            int upperCount = s.Count(Char.IsUpper);
            string sLower;

            if (upperCount == s.Length)
            {
                return s;
            } else
            {
                sLower = s.ToLower();
                return sLower;
            }
            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Тема 5. Домашнее задание.\n");
            // Задание 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание 3. Создать метод, принимающий текст и удаляющий повторные символы в строке.\n");
            Console.ResetColor();
            Console.WriteLine("Введите предложение\n");

            string result = RemoveDuplicates(IsUpper(Console.ReadLine()));

            Console.WriteLine("Результат:\n" + result);
            

            Console.ReadLine();
        }
    }
}
