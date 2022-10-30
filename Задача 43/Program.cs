// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователе;.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> ( -0,5; -0,5)

void TwoStrong(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double numX = k2 - k1;
        double num = b1 - b2;
        double X = num / numX;
        double Y = k2 * (X) + b2;
        Console.WriteLine($"Точка пересечения этих двух прямых({X}; {Y})");
    }
    else
    Console.WriteLine($"Не пересекаются");
}

Console.Clear();
Console.WriteLine("Введите b1 ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1 ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2 ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2 ");
double k2 = double.Parse(Console.ReadLine()!);
TwoStrong(b1, k1, b2, k2);