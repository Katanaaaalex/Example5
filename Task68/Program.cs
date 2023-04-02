// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
int num = Akkerman(numberM,numberN);
Console.Write(num);
int Akkerman(int numberM, int numberN)
{
    if(numberM == 0)
    {
        return numberN + 1;
    }
    else
    if(numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}