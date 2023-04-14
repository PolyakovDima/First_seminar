﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// Задача:
// 1. Принять число от пользователя.
// 2. Показать все чётные числа включаю это самое число.

Console.Write("Введите число: ");
string s = Console.ReadLine();
if (int.TryParse (s, out int n))
{
    Console.Write("Чётные числа от 1 до " + n + ": ");
    for (int i = 2; i <= n; i += 2)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("Ошибка при вводе числа");
}