// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;

namespace task_04
{
    class Program
    {
        public static int QuantityDigit(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }

        public static void Digit(int num, int count)
        {
            int temp = 1;
            for (int i = 1; i < count; i++)
            {
                temp *= 10;
            }

            for (int i = 0; i < count; i++)
            {
                int currentDigit = num / temp;
                Console.Write(currentDigit);

                if (i != count - 1)
                {
                    Console.Write(", ");
                }

                num %= temp;
                temp /= 10;
            }
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
                    int count = QuantityDigit(number);
                    Digit(number, count);
                    inputError = false;
                }
            } while (inputError);
        }
    }
}