// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 3, 19, 345, 3] -> да

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}


bool isOk(int[] array, int number)
{
    //bool trust = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            //bool trust = true;
            return true;
        }
    }
    return false;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int number = Convert.ToInt32(Console.ReadLine());


if (isOk(array, number))
{
    System.Console.WriteLine("Элемент найден");
}
else
{
    System.Console.WriteLine("Элемент не найден");
}

// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // 3; массив [6, 3, 19, 345, 3] -> да

// int[] FillArrayWithRandomNumbers(int length)
// {
//     int[] arr = new int [length];
//     Random rnd = new Random();
//     for(int i =0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// int number = Convert.ToInt32(Console.ReadLine());
// bool isOk = false;

// for(int i = 0; i < array.Length; i++)
// {
//     if(number == array[i])
//     {
//         isOk = true;
//         break;
//     }
// }
// if(isOk)
// {
//     System.Console.WriteLine("Элемент найден");
// }
// else
// {
//     System.Console.WriteLine("Элемент найден");
// }