// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool checkNumber = CheckNumber(num);
Console.WriteLine(checkNumber ? "True" : "False");
bool CheckNumber(int num)
{
    if(num /10000 == num % 10 && num / 1000 %10 == num /10 % 10)
    return true;
    else
    return false;
}