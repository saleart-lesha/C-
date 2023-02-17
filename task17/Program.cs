// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Promt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// string Quaters(int x, int y)
// {
//     string result = "";
//     if(x > 0 && y > 0)
//     {
//         result = "Точка лежит в 1-ой четверти";
//     }
//     else if(x < 0 && y > 0)
//     {
//         result = "Точка лежит вo 2-ой четверти";
//     }
//     else if(x < 0 && y < 0)
//     {
//         result = "Точка лежит в 3-ей четверти";
//     }
//     else if(x > 0 && y < 0)
//     {
//         result = "Точка лежит в 4-ой четверти";
//     }
//     else
//     {
//         result = "Точка лежит на одной из осей";
//     }

//     return result;
// }


// int X = Promt("Введите X координату -> ");// = int X = Convert.ToInt32(Console.ReadLine())
// int Y = Promt("Введите Y координату -> ");

// string quater = Quaters(X, Y);
// Console.WriteLine(quater);

double number = 5.321321321321;
double result1 = Math.Round(number,2);// Округление
System.Console.WriteLine(result1);
double master = Math.Pow(number,2); // Возведение в квадрат
double number1 = Math.Sqrt(25); // квадратный корень
System.Console.WriteLine(number1);
double result = Math.Round(Math.Sqrt(Math.Pow(number, 2)), 2);
System.Console.WriteLine(result);