/*Задача 2.1: Напишите программу,
которая на вход принимает два числа
и выдаёт, какое число большее,
а какое меньшее: a = 2 b = 10 -> max = 10*/

int numberA = 2;
int numberB = 10;
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
Console.WriteLine(max);