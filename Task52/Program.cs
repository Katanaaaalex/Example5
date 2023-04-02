// Задача 52. Задайте двумерный 
// массив из целых чисел. 
// Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 

    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

double AverageDoubleElements(int[,] arr, int column)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, column];
    }
    return sum / arr.GetLength(0);
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(array2d);
double averageDoubleElements = 0;
for (int i = 0; i < array2d.GetLength(1); i++)
{
    averageDoubleElements += AverageDoubleElements(array2d, i);
}
averageDoubleElements /= array2d.GetLength(1);
Console.WriteLine($"Среднее арифметическое каждого столбца: {averageDoubleElements}");

