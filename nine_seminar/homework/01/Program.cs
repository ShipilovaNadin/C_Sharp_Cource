// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void Numbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
    else
    {
        m++;
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
}
Console.WriteLine("Введите значение числа m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение числа n: ");
int n = int.Parse(Console.ReadLine());
Numbers(m, n);

