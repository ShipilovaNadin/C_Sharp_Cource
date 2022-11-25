// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

string Cut2Num (int number)
{
    Console.WriteLine(number);
    return $"{number / 100 * 10 + (number % 10)}";
}

Console.WriteLine (Cut2Num(new Random().Next(100,1000)));
