// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Checked(int quater)
{
    if(quater >= 1 && quater <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string[] quaters ={"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};

int quater = Promt("Введите четверть: ");

if(Checked(quater))
{
    Console.Write(quaters[quater - 1]);
}
else
{
    Console.Write("Неправильный номер четверти");
}
