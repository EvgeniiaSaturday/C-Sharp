/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
int A =number;
if (A > 0 && A<8 )
{
   if( A==1 || A==2 || A==3 || A==4 || A==5)
   {
    Console.WriteLine("нет");
   }
    else
    {
      Console.WriteLine("да");
    }
}