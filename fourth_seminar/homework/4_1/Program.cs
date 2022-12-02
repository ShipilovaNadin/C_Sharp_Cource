// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++) 
    {
        result = result * num1;
    }
    return result;
}

//int result = Math.Pow(num1, num2);

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Degree(A, B));
