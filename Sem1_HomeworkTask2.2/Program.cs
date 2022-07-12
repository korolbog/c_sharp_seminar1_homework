/*Задача 2.2: Напишите программу,
которая на вход принимает два числа
и выдаёт, какое число большее,
а какое меньшее: a = -9 b = -3 -> max = -3*/

int numberA = -9;
int numberB = -3;
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
Console.WriteLine(max);