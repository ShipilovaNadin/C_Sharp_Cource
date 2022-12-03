//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i} ");

// Вариант через цикл while
// void Chet(int N)
// {
//    int i = 0;
//    double pere;
//    while (i < N )
//    {
//         i += 1;
//         if (i == (N))
//         {
//             pere = Math.Pow(i,2);
//             Console.Write($"{pere}");
//         }
//         else
//         {
//         pere = Math.Pow(i,2);
//         Console.Write($"{pere},");
//         }
//    }
// }
// Console.WriteLine("введите ч");
// int chislo = int.Parse(Console.ReadLine());
// Chet(chislo);
