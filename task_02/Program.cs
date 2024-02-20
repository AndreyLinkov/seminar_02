// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System;

namespace task_02
{
    class Program
    {
        public static void Quarter(int coorX, int coorY)
        {
            if (coorX > 0 && coorY > 0)
                Console.WriteLine("Координаты находятся на 1 четверти");
            if (coorX > 0 && coorY < 0)
                Console.WriteLine("Координаты находятся на 2 четверти");
            if (coorX < 0 && coorY < 0)
                Console.WriteLine("Координаты находятся на 3 четверти");
            if (coorX < 0 && coorY > 0)
                Console.WriteLine("Координаты находятся на 4 четверти");
        }

        static void Main()
        {
            Console.Clear();

            int coorX;
            int coorY;
            bool inputError = true;

            do
            {
                Console.Write("Введите координаты точки X не равные 0: ");
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out coorX) && coorX != 0)
                    inputError = false;
            } while (inputError);

            inputError = true;

            do
            {
                Console.Write("Введите координаты точки Y не равные 0: ");
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out coorY) && coorY != 0)
                    inputError = false;
            } while (inputError);

            Quarter(coorX, coorY);
        }
    }
}