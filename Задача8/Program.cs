﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int K = 2;
while (K <= num)
{
    Console.Write($"{K}, ");
    K += 2;
}
