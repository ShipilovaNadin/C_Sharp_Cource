// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void CheckPalindrom(int num)
{
    if (num < 100000 && num > 9999)
    {
        if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
        {
            Console.WriteLine("-> да");
        }
        else
        {
            Console.WriteLine("-> нет");
        }
    }
    else
        Console.WriteLine("число не пятизначное");
}

int a = ReadNumber("Введите число:");
CheckPalindrom(a);