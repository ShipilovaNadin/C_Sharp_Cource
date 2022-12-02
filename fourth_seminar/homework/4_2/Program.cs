//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int SumNums(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        result = result + (number % 10);
        number = number / 10;
    }

    return result;
}

Console.Write("Введите число: ");
Console.WriteLine("Сумма цифр в числе равна " + SumNums(int.Parse(Console.ReadLine())));
