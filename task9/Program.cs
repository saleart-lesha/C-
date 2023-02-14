// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);// 27
Console.WriteLine($"Ваше случайное число: {number}");

int digit1 = number/10;
int digit2 = number%10;

if(digit1 > digit2)
{
    Console.Write($"Наибольшая цифра числа: {digit1}");
}
else if (digit2 > digit1)
{
    Console.Write($"Наибольшая цифра числа: {digit2}");
}
else
{
    Console.Write($"Цифры равны");
}

