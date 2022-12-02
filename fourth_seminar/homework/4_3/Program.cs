// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

void Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(); // чтобы ограничить элемент массива кокретным значением в () после Next нужно указать мин и мах
        Console.Write($"{array[i]} ");
    }   
}

Console.Write("Введите длину массива: "); // для выполнения условия задачи нужно ввести 8
Massiv(int.Parse(Console.ReadLine()));