﻿// 2. Напишите программу, которая 
// на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число: a");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: b");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
     Console.WriteLine("Первое число максимальное");
}
else 
if (num1 < num2)
{
     Console.WriteLine("Второе число максимальное");
}
