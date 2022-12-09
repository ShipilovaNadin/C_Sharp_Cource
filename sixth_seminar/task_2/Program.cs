// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

string Bin(int n)
{
    
    string result = "";
    while (n > 0)
    {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Bin(num));