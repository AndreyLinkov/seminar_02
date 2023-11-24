int NumeralNumber(int num) {

    string numStr = num.ToString();
    if (numStr[0] > numStr[1]) {
        Console.WriteLine($"Цифра {numStr[0]} больше, чем {numStr[1]}");
        return 1;
    }
    else if (numStr[0] == numStr[1]) {
        Console.WriteLine($"Цифры {numStr[0]} и {numStr[1]} равны");
        return 0;
    }
    else {
        Console.WriteLine($"Цифра {numStr[1]} меньше, чем {numStr[0]}");
        return 2;
    }
}

Console.Write("Введите двузначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10 || number > 99) {
    Console.Write("Ошибка. Введите двузначное положительное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int numeralNumber = NumeralNumber(number);