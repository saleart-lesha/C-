Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int check = number % 2;
int temp = 2;

if (check == 0)
{
    while(temp < number)
    {
    Console.Write($"{temp} ");
    temp = temp + 2;
    }
} else
{
while(temp < number)
    {
    Console.Write($"{temp} ");
    temp = temp + 2;
    }
}
