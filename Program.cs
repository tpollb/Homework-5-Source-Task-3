using System;
using System.Linq;

namespace Homework_5_Source_Task_3
{
    class Program
    {
        /// <summary>
        /// метод, принимающий текст и удаляющий повторные символы в строке.
        /// </summary>
        /// <param name="Source">исходная строка текста</param>
        static void RemoveDoubles(string Source)
        {
            char[] arr = Source.ToCharArray(0, Source.Length);
            char[] arr1 = arr.Distinct().ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
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
             
            Console.WriteLine("Результат:\n");
            RemoveDoubles(str);

            Console.ReadLine();
        }
    }
}
