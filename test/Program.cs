Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
while(temp <= N && N % 2 == 0)
{
    Console.Write($"{temp} ");
    temp++;// temp = temp + 1
}