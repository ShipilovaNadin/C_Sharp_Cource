// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int Summ(int m, int n)
{
    if (m > n) return 0;
    return m + Summ(m + 1, n);
}

Console.WriteLine("Введите значение числа m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение числа n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N составляет: {Summ(m, n)}");