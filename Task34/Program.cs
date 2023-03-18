// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}
int GetEvenNumber(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) even++; 
    }
    return even;
}

int[] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);
int getEvenNumber = GetEvenNumber(array);
Console.WriteLine($"Количество положительных четных элементов = {getEvenNumber}");
