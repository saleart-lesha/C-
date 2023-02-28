// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник сo сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону: ");
int C = Convert.ToInt32(Console.ReadLine());

if(A + B > C && B + C > A && A + C > B)
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}
