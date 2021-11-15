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
        static char[] RemoveDoubles(string Source)
        {
            char[] arr = Source.ToCharArray(0, Source.Length);
            char[] arr1 = arr.Distinct().ToArray();
            return arr1;
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
            string str = Console.ReadLine();
             
            Console.WriteLine("Результат:\n");
            
            char[] Source = RemoveDoubles(str);

            for (int i = 0; i < Source.Length; i++)
            {
                Console.Write(Source[i]);
            }

            Console.ReadLine();
        }
    }
}
