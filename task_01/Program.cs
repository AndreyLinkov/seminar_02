// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;

namespace task_01
{
    class Program
    {
        public static void Multiple(int number)
        {
            if (number % 7 == 0 && number % 23 == 0 && number != 0)
                Console.WriteLine($"Число {number} кратно 7 и 23");
            else
                Console.WriteLine($"Число {number} не кратно 7 и 23");
        }

        static void Main()
        {
            Console.Clear();
            bool inputError = true;
            do
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out int number))
                {
                    Multiple(number);
                    inputError = false;
                }
            } while (inputError);
        }
    }
}