// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 - 8
// 12 - 2
// 85 - 8

// обычный код

int number = new Random().Next(10, 100); // Рандом - method, который выдает случайное число в заданном диапазоне
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstDigit = number / 10; // при деление на 10 остается 7.8, берется целое число
// int secondDigit = number % 10; // остаток от деления на 10

// // if (firstDigit == secondDigit) Console.Write($"Наибольша цифра числа {number} -> цифры одинаковые");
// // else if (firstDigit > secondDigit) Console.Write($"Наибольша цифра числа {number} -> {firstDigit}");
// // else Console.Write($"Наибольша цифра числа {number} -> {secondDigit}");

// int res = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор
// Console.Write($"Наибольша цифра числа {number} -> {res}");

// Пример метода

int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if(firstDigit == secondDigit) return -1;
    // if (firstDigit > secondDigit) return firstDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();
Console.Write($"Наибольша цифра числа {number} -> {res}");