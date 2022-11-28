// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string ThirdNum(int num)
{
    if (num < 100)
        return "третьей цифры нет";

    else if (num > 99 && num < 1000)
        return $"{num % 10}";

    else
        while (num > 999)
        {
            num = num / 10;
        }
    return $"{num % 10}";
}

Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(ThirdNum(number));