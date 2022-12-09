// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void TriG()
{
    Console.WriteLine("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int c = int.Parse(Console.ReadLine());
    if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("треугольник существует");
    else
    Console.WriteLine("треугольника не существует");
}

TriG();



