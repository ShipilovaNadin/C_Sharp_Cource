// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0) a = 0 +(-a);

int ost = a % 2;

if (ost > 0) Console.WriteLine("нет");
else Console.WriteLine("да");
