// Программа которая выводит случайное число из отрезка [10,99] и показыает наибольшую цифру числа

int MaxNumber(int num)
{
    Console.WriteLine(num);

    if (num % 10 > num / 10)
        return num % 10;
    else
        return num / 10;
}

Console.WriteLine(MaxNumber(new Random().Next(10,100)));
