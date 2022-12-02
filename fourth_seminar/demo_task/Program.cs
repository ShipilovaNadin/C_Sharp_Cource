// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNums(int num)
{
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

