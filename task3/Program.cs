// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write("Понедельник");
        break;

    case 2:
        Console.Write("Вторник");
        break;

    case 3:
        Console.Write("Среда");
        break;

    case 4:
        Console.Write("Четверг");
        break;

    case 5:
        Console.Write("Пятница");
        break;

    case 6:
        Console.Write("Суббота");
        break;

    case 7:
        Console.Write("Воскресенье");
        break;

    default:
        Console.Write("Не верное значение!");
        break;
}

// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day == 1)
// {
//     Console.Write("Понедельник");
// }
// else if(day == 2)
// {
//     Console.Write("Вторник");
// }
// else if(day == 3)
// {
//     Console.Write("Среда");
// }
// else if(day == 4)
// {
//     Console.Write("Четверг");
// }
// else if(day == 5)
// {
//     Console.Write("Пятница");
// }
// else if(day == 6)
// {
//     Console.Write("Суббота");
// }
// else if(day == 7)
// {
//     Console.Write("Воскресенье");
// }
// else
// {
//     Console.Write("Такого дня недели нет");
// }

