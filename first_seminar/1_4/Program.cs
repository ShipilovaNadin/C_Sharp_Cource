// 4. Напишите программу вычисления модуля числа.

Console.Write("Введите число:");              // Console.WriteLine("Задайте число ");
var s = Console.ReadLine();                   // int num = int.Parse(Console.ReadLine()!);
int N = s == null ? 0 : int.Parse(s);         // int mod;
Console.WriteLine($"{Math.Abs(N)}");          // if (num > 0) mod = num;
                                              // else (mod = 0 +(-num));
                                              // Console.WriteLine (mod);