// Напишите прогамму, которая принимает на вход число
// и приверяет, кратно ли оно одновременно 7 и 23
// 14 - нет 
// 46 - нет 
// 161 - да 

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool Multip(int num, int a, int b)
{
    return num % a == 0 && num % b == 0; // Возвращает True, если условие работает
}
if (Multip(number, 7, 23)) Console.WriteLine($"{number} -> Да");
else Console.WriteLine($"{number} -> Нет");