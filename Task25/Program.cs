// Напишите цикл, который принимает 
// на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
int powerOfNumbers = PowerOfNumbers(number1, number2);
Console.WriteLine($" A в степени B равно = {powerOfNumbers}");
int PowerOfNumbers(int powNumbers, int degreeNumbers)
{
    int powerOfNumbers = 1;
    for (int i = 1; i <= degreeNumbers; i++)
    {
        powerOfNumbers *= powNumbers; 
    }
    return powerOfNumbers;
}
}
else
{
	Console.WriteLine("Введите натуральное число");
}
