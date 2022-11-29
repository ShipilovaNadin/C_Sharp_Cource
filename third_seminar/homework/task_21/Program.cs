// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cubes(int n)
{
    int i = 0;
    double pere;
    while (i < n)
    {
        i += 1;
        if (i == (n))
        {
            pere = Math.Pow(i, 3);
            Console.Write($"{pere}");
        }
        else
        {
            pere = Math.Pow(i, 3);
            Console.Write($"{pere},");
        }
    }

}
Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine());
Cubes(N);
