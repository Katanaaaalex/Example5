// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого 
// элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
Console.WriteLine("Введите количество строк m массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

Console.WriteLine("Введите номер строки a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца b");
int b = Convert.ToInt32(Console.ReadLine());

if (a < m && b < n)
{
    {
        if (a > 0 && b > 0)
{ 
int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
int elementExistence = ElementExistence(array2d);
Console.WriteLine($"Значение элемента = {elementExistence}");
int ElementExistence(int[,] arr)
{
    int size = arr.GetLength(0);
    if (arr.GetLength(1) < size) size = arr.GetLength(1);
    int elem = 0;
    for (int i = 0; i < size; i++)
    {
        elem = arr[i, i];
    }
    return elem;
}
}
else
{
    Console.Write("Введите положительное число");
}
}
}
else
{
Console.Write("Такого элемента в массиве нет");
}

