// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max+1);
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
int GetPositiveNumber(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) num++; 
    }
    return num;
}

int[] array = CreateArrayRndInt(8, -10, 10);
PrintArray(array);
int getPositiveNumber = GetPositiveNumber(array);
Console.WriteLine($"Количество положительных элементов = {getPositiveNumber}");