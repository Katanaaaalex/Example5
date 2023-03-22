// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        double num = new Random().NextDouble() * (max - min) + min;
        arr [i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayDouble(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}
double GetDifferenceElements(double[] arr)
{
    double diff = 0;
    double max = arr[1];
    double min = arr[1];
    for (int i = 1; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];
    if (min > arr[i]) min = arr[i];
    diff = max - min;
}
    return diff;
}

double[] array = CreateArrayRndDouble(8, 1, 10);
PrintArrayDouble(array);
double getDifferenceElements = GetDifferenceElements(array);
Console.WriteLine($"Разница между max и min= {getDifferenceElements}"); 