// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if((k1 == k2) && b1 == b2)
Console.Write("Прямые совпадают");
else
if(k1 == k2)
Console.Write("Прямые параллельны");

if (k1 != k2)
{
double getX = GetX(b1, k1, b2, k2);
double getY = GetY(getX, k2, b2);
Console.WriteLine($"({getX},{getY})");
}
double GetX(double b01, double k01, double b02, double k02)
{
    double x = (b02 - b01) / (k01 - k02);
    return x;
}
double GetY(double x, double b02, double k02)
{
    double y = k02 * x + b02;
    return y;
}









