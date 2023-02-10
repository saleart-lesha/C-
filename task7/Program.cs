// Задача №7. Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int LastNumber = 0;
if(N > 99 && N < 1000)
{
    LastNumber = N%10;
    Console.Write(LastNumber);
}
else
{
    Console.Write("Некорректный ввод");
}


