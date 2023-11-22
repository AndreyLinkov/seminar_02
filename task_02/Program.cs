bool MultipleNumber (int num) {
    if (num%7==0 && num%23==0) {
        return true;
    }
    else {
        return false;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool multiple = MultipleNumber(number);

if (multiple == true) {
    Console.WriteLine($"Введенное число {number} кратно 7 и 23");
}
else {
    Console.WriteLine($"Введенное число {number} не кратно 7 и 23");
}