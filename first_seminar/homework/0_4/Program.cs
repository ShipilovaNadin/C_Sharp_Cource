// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine()!;
int N = int.Parse(a);
int n = 2;


while(n < N)
{
    Console.WriteLine($"{n}");
    n +=2;
}
