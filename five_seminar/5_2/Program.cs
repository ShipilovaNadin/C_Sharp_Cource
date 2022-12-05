// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 
// 3; массив [6, 7, 19, 345, 3] -> да

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

string Sertch (int[] arr, int num)
{
    for (int i = 0; i < arr_1.Length; i++)
    {
        arr_1[i] = - arr_1[i];
    }
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(Sertch(arr_1, int.Parse(Console.ReadLine())));
