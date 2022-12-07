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

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            result += arr[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {result}");
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()),
                   int.Parse(Console.ReadLine()),
                   int.Parse(Console.ReadLine()));

// пытаюсь компактно включить в вызов значения с консоли текст, но выдет ошибку...(спросить на семинаре)
// int[] arr_1 = Mass
//     (
//     Console.WriteLine("Введите длину массива: " + int.Parse(Console.ReadLine())),
//     Console.WriteLine("Введите первый элемент массива: " + int.Parse(Console.ReadLine())),
//     Console.WriteLine("Введите последний элемент массива: " + int.Parse(Console.ReadLine()))
//     );
Print(arr_1);
SumNegPosition(arr_1);

