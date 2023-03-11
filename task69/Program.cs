// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int AinGradeB(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    return A * AinGradeB(A, B - 1); // A*=AinGradeB(A, B - 1)
}

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} = {AinGradeB(A, B)}");