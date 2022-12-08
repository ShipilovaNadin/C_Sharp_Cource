// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
  
  void InputArray(int [] array)
  {
      for (int i = 0; i < array.Length; i++)
          array[i] = new Random().Next(1, 11);
  }
  
  void ReleaseArray(int[] array)
  {
    //for (int i = 0; i < array.Length / 2 + array % 2; i++) // задаем условие чтобы цикл прошелся по половине массива
       // если массив состоит из четного кол-ва чисел то будет ровно половина, если из нечетного то половина плюс 1 (захватываем большую часть массива)
   // Console.Write($"{array[i] * array[array.Length - i -1]} "); // тут мы берем первый элемент массива и умножаем на последний и движемся к центру
                                                       // длина массивва - 1 = индекс последнего элемента; минус i дает нам индекс элемента "пары" i
 //вариант с созданием отдельного нового массива для записи результата умножение
    int [] resultArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        resultArray[i] = array[i]*array[array.Length - i - 1];
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
  }

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнй массив: [{string.Join(", ", array)}]");
ReleaseArray(array);