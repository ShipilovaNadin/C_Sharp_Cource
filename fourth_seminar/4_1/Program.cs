// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int Amount(long num)
// {
//     if(num == 0)
//     {
//         return(1); 
//     }
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// Console.Write("Введите число: ");
// Console.WriteLine(Amount(long.Parse(Console.ReadLine())));
//  вариант 2
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
while (n / 10 != 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);
