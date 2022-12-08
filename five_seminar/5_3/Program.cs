// Задача 3.  Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

int CountNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        result++;
    }
    return result;
}

//Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];
InputArray(array);
Console.WriteLine($"Начальнй массив: [{string.Join(", ", array)}]");
Console.WriteLine("Количество элементов массива в заданном отрезке: " + CountNum(array));
