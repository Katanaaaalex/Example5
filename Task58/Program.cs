// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateFirstMatrixRndInt(int rows1, int columns1, int min, int max)
{
    int[,] matrix = new int[rows1, columns1]; 

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

void PrintFirstMatrix(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] CreateSecondMatrixRndInt(int rows2, int columns2, int min, int max)
{
    int[,] matrix = new int[rows2, columns2]; 

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

void PrintSecondMatrix(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException("Количество столбцов первой матрицы не соответствует количеству строк второй матрицы.");
    }

    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}


int[,] array2d1 = CreateFirstMatrixRndInt(2, 2, 1, 10);
PrintFirstMatrix(array2d1);

int[,] array2d2 = CreateSecondMatrixRndInt(2, 2, 1, 10);
PrintSecondMatrix(array2d2);
int[,] result = MultiplyMatrices(array2d1, array2d2);
PrintMatrix(result);

