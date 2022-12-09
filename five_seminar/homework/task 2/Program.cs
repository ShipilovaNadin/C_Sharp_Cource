// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях (нечетные позиции == четные индексы).
Console.Clear();
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumNegPosition(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++) // i+=2 - шаг в 2 позволяет ходить по четным (начинаем с 0)и нечетным (начинаем с i = 1)
    {
        if (i % 2 == 0)                  // тогда это не надо
            result += arr[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {result}");
}

    Console.WriteLine("Введите длину массива: ");
    int leght = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите первый элемент массива: ");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите последний элемент массива: ");
    int j = int.Parse(Console.ReadLine());
int[] arr_1 = Mass(leght, i, j);
Print(arr_1);
SumNegPosition(arr_1);

