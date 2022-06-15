/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{
  int result= number / 100;
  int result1= result % 10;
  Console.WriteLine(result1);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
