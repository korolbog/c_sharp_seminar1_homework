﻿/*Задача 4: Напишите программу,
которая принимает на вход три числа
и выдаёт максимальное из этих чисел: 2, 3, 7 -> 7 */

int numberA = 2;
int numberB = 3;
int numberC = 7;
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine(max);