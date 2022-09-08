// Напишите программу, которая выводит случайное трехзначное число
// удаляет вторую цифру этого числа
// 456 - 46
// 782 - 72
// 918 - 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

int RemoveSecondDigit(int num)
{
int firstDigit = number / 100;
int secondDigit = number % 10;
int thirdDigit = firstDigit*10+secondDigit;
return  thirdDigit;
}

int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} -> {result}");