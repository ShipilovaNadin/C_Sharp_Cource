// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNums(int num)  // можно решать по формуле прогрессии сумма = ((А1+Апоследня)/2) * количество элементов в последовательности
{                      // но в этом случае нужен формат переменных double, иначе ответ будет не верным
     if(num == 0)
    {
        return(1);
    }
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));

