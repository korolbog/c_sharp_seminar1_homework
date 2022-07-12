/*
Задача 8: Напишите программу,
которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N:
5 -> 2, 4
*/
Console.Write("Введите ваше число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int index = 0;
string result = "";
while (index < N)
{
    array[index] = index + 1;
    if (array[index] % 2 == 0)
    {
       result += array[index].ToString() + ", ";
    } 
    index++;
}
Console.WriteLine(result.Remove(result.Length-2, 2));
Console.ReadLine();
