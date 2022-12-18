// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int[]SummaRowElement (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[] sum = new int [row_size];
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            sum[j] += arr[i,j];
        }
    }
    return sum;
}

void FindMin(int[] arr)
{
    int min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = i;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min+1}");
}
    
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
int [] mass = SummaRowElement(arr_1);
FindMin(mass);
