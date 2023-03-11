// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Sum(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + Sum(number / 10);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(number));