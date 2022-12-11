// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindXY()
{
    Console.Write("Задайте значение b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Задайте значение k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Задайте значение b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Задайте значение k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    //k2 * x + b2 = k1 * x + b1 -> x = (b2 - b1) / (k1 - k2)
    if (k1 == k2) // угловые коэффициенты равны
        Console.WriteLine("Прямые параллельны.");
    else if (k1 / k2 == b1 / b2)
        Console.WriteLine("Прямые совпадают.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения прямых равны: ({x};{y}).");
    }
}

FindXY();
