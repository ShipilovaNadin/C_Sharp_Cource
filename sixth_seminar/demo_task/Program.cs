// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.) картежи


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

void RevMas(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}

Console.WriteLine("Введите длину массива: ");
int leght = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первый элемент массива: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последний элемент массива: ");
int j = int.Parse(Console.ReadLine());
int[] arr_1 = Mass(leght, i, j);
Print(arr_1);
RevMas(arr_1);
Print(arr_1);
