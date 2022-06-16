/*Доп. задача 16: Напишите программу, которая принимает на вход два 
числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

Console.Clear();

int firstNumber = Input("Введите первое число");
int secondNumber = Input("Введите второе число");

if(firstNumberSquare == secondNumber || secondNumberSquare == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет"); 
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Convert.ReadLine());
}