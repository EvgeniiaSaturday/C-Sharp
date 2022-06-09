/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int A = number;

if (A % 2 == 0)
{
    Console.Write("четное");
}
else
{
    Console.Write("нечетное");
}