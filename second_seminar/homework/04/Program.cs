// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void CheckDayOfTheWeek (int DayNum) 
{
  if (DayNum == 6 || DayNum == 7)
  {
    Console.WriteLine("этот день выходнойт -> да ");
  }
  else if (DayNum < 1 || DayNum > 7) 
  {
    Console.WriteLine("Вы ввели неверную цифру, это не день недели");
  }
  else Console.WriteLine("этот день не выходной -> нет");
}

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = int.Parse(Console.ReadLine());
CheckDayOfTheWeek(number);

