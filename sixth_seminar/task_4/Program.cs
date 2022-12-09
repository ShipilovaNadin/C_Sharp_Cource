// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
Console.Clear();

void PrintArray(int[,] matr) //задаем функцию переменной которой двумерный массив матр
{
    for (int i = 0; i < matr.GetLength(0); i++)  // первый цикл проходится по строкам ->(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // второй цикл проходится по столбцам -> (1)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] MasClone(int[,] arr)
{
    int row = arr.GetLength(0);
    int colum = arr.GetLength(1);

    int[,] new_arr = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
            new_arr[i, j] = arr[i, j]; /// значение элемента из входящего в функцию массива передаем в новый массив
    }
    return new_arr;
}
Console.WriteLine("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colum = int.Parse(Console.ReadLine());
int[,] arr_1 = new int[row, colum];
FillArray(arr_1);
Console.WriteLine("Изначальный массив: ");
PrintArray(arr_1);
int[,] arr_2 = MasClone(arr_1);
Console.WriteLine("Копия массива: ");
PrintArray(arr_2);
