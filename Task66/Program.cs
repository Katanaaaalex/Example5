// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
int num = SumNumbersInRange(numberM,numberN);
Console.Write(num);

int SumNumbersInRange(int numberM, int numberN)
{
    if(numberN <= numberM)
    {
        return numberM;
    }
    else
    {
        return numberN + SumNumbersInRange(numberM, numberN - 1);
    }
}