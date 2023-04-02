// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}
int MinElements(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int InputLine()
{
  Console.WriteLine("Введите номер строки: ");
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
int[] rowSums = new int[array2d.GetLength(0)];
for (int i = 0; i < array2d.GetLength(0); i++)
{
    rowSums[i] = 0;
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        rowSums[i] += array2d[i,j];
    }
}
int minRow = MinElements(rowSums);
int inputLine = InputLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");
Console.WriteLine($"Выбранная строка: {inputLine}");