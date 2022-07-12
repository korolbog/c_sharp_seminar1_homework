/*Задача 4.2: Напишите программу,
которая принимает на вход три числа
и выдаёт максимальное из этих чисел: 22 3 9 -> 22 */

int numberA = 22;
int numberB = 3;
int numberC = 9;
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