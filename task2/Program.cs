﻿// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если число 2 не кратное числу 1, то программа выдает остаток от деления.
// 34, 5 - не кратно, остаток 4
// 16, 4 - кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int ost = number1 % number2;

if (ost == 0)
{ 
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}. Остаток от деления {ost}");
}
