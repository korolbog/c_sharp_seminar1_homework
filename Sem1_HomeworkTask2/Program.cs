/*Задача 2.0: Напишите программу,
которая на вход принимает два числа
и выдаёт, какое число большее,
а какое меньшее: a = 5; b = 7 -> max = 7*/
int numberA = 5;
int numberB = 7;
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
Console.WriteLine(max);