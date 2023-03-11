// // Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// // N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5, 6"

// void RoadToN(int N)
// {
//     if(N == 0)
//     {
//         return;
//     }
//     RoadToN(N-1);
//     System.Console.Write($"{N} ");
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// RoadToN(number);

void RoadTon(int N, int M)
{
  if(N - 1==M)
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

