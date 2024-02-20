// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

namespace task_03
{
    class Program
    {
        public static void Digit(int number)
        {
            int firstNum = number / 10;
            int secondNum = number % 10;
            if (firstNum > secondNum)
                Console.WriteLine($"{firstNum} больше, чем {secondNum}");
            else if (firstNum < secondNum)
                Console.WriteLine($"{secondNum} больше, чем {firstNum}");
            else
                Console.WriteLine($"{secondNum} и {firstNum} раны");
        }

        static void Main()
        {
            Console.Clear();

            bool inputError = true;
            do
            {
                Console.Write("Введите двухзначное число: ");
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out int number) && number > 9 && number < 100)
                {
                    Digit(number);
                    inputError = false;
                }
            } while (inputError);
        }
    }
}