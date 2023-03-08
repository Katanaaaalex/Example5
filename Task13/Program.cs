// Напишите программу, которая выводит 
// третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    int result = ThirdDigit(num);
    Console.Write(result); 
}
else
{
    Console.Write("Третьей цифры нет");
}
int ThirdDigit (int number)

{
    while (number > 999)
    {
    number = number / 10;   
    }
    return number % 10;
}
  