// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
string a = Console.ReadLine();
int N = int.Parse(a);

//int NegN = - N;
// while(NegN <= N)
// {
//     Console.Write($"{NegN} ");
//     NegN +=1;
// }
for (int NegN = (-1)*N; NegN <= N; NegN++)
Console.Write(NegN + " ");
