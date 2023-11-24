int NumeralNumber(int num) {
    string numStr = num.ToString();
    char[] digits = numStr.ToCharArray();
    int i=0;

    while (i<digits.Length) {
        Console.Write(numStr[i]);

        if (i<digits.Length-1) {
            Console.Write(", ");
        }
        i++;
    }
    return 0;
}
try {
    Console.Write("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    NumeralNumber(number);
}
catch {
    Console.Write("Ошибка: Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    NumeralNumber(number);
}