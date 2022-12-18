//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Multiplication(int[,] arr01, int[,] arr02)
{
    int[,] resultArray = new int[arr01.GetLength(0), arr02.GetLength(1)];
    if (arr01.GetLength(1) == arr02.GetLength(0))
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                for (int k = 0; k < arr01.GetLength(1); k++)
                {
                    resultArray[i, j] = resultArray[i, j] + arr01[i, k] * arr02[k, j];
                }

            }
        }
        return resultArray;
    }
    else
    {
        Console.WriteLine("Количество столбцов 1 массива не равно количеству строк 2 массива");
        return resultArray;
    }
}

Console.Write("Enter the number of rows for 1 matrix: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns for 1 matrix: ");
int column1 = int.Parse(Console.ReadLine());

int[,] matrix1 = MassNums(row1, column1,
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));

Console.Write("Enter the number of rows for 2 matrix: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns for 2 matrix: ");
int column2 = int.Parse(Console.ReadLine());

int[,] matrix2 = MassNums(row2, column2,
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));

Console.WriteLine("Первая матрица");
Print(matrix1);
Console.WriteLine("Вторая матрица");
Print(matrix2);
Console.WriteLine("Результат умножения двух матриц");
Print(Multiplication(matrix1, matrix2));
