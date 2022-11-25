// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string SecondNum(int num)
{
    if (num > 99 && num < 1000)
        return $"{num / 10 % 10}";
    else if (num > 1000)
        return "wrong number";
    else 
    return "wrong number";
}

Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SecondNum(number));
