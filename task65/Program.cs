// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void RoadTon(int N, int M)
{
  if(N - 1 == M)
  {
    return;
  }
  RoadTon(N,M - 1);
  Console.Write($"{M} ");
}

System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
RoadTon(number1, number2);