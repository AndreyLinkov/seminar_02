int CoordinateNumber (int X, int Y) {
    if (X > 0 && Y > 0) {
        return 1;
    }
    else if (X < 0 && Y > 0) {
        return 2;
    }
    else if (X < 0 && Y < 0) {
        return 3;
    }
    else {
        return 4;
    }
}

Console.Write("Введите координату X: ");
int coorX = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int coorY = Convert.ToInt32(Console.ReadLine());

int coordinate = CoordinateNumber(coorX, coorY);

Console.WriteLine($"Координата находится на {coordinate} плоскости");