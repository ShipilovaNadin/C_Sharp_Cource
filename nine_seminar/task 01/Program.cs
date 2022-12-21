// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Factorial (int n)
{
    if(n == 0) return; 
    Factorial(n - 1);
    Console.Write($"{n} ");
}
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Factorial(n);