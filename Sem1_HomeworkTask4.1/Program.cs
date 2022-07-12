/*Задача 4.1: Напишите программу,
которая принимает на вход три числа
и выдаёт максимальное из этих чисел: 44 5 78 -> 78 */

int numberA = 44;
int numberB = 5;
int numberC = 78;
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