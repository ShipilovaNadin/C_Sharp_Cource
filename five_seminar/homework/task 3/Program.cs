// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}   ");
    Console.WriteLine();
}

double[] Mass()
{
    double[] arr = new double[20];
    Random n_new = new Random(); // не понимаю что означает n_new
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2); // тут мы говорим что берем в массив 
                                                                     // значения от -10 до 12 и округляем до 2 цифр после запятой
    return arr;
}

void SelectionSort(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
void DifMaxMix(double[] array)
{
    double result = array[array.Length - 1] - array[0];
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {result}");
}

double[] arr_1 = Mass();
Print(arr_1);
SelectionSort(arr_1);
Print(arr_1);
DifMaxMix(arr_1);
