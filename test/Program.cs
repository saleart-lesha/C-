/* double promtDbl(string str)
{
    Console.Write( $"Введите {str} :");
    double res = Convert.ToDouble(Console.ReadLine());
    return res;
} */

int promtInt(string str)
{
    Console.Write( $"Введите {str} :");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int[] FillArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

double[] FillArrayDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble();
    }
    return arr;
}

/*

https://gb.ru/lessons/305490/homework
Преподаватель ждет ваше задание до 16 марта, 20:00 +03:00 UTC

Знакомство с языками программирования (семинары)
Урок 5. Функции и одномерные массивы
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
!!! even четный, odd нечетный
*/

void Task34()
{ 
    int CountEvenItems(int[] arrInt)
    {
        int len = arrInt.Length, countOdd = 0;
        for (int i = 0; i < len; i++){
            if (arrInt[i] % 2 == 0) countOdd++;
        }
        return countOdd;
    }

    string tsk34 = " \n" 
    + "Задача 34: Задайте массив заполненный случайными положительными   \n"
    + "трёхзначными числами. Напишите программу, которая покажет количество  \n"
    + "чётных чисел в массиве.  \n";

    Console.Write( $" {tsk34} \n");

    int ln = promtInt(" длину массива ");
    int[] arrInt = FillArrayInt(ln, 100, 1000); 

    Console.WriteLine(
        $"[{string.Join(", ", arrInt)}] \n "
        +$"количество чётных чисел : {CountEvenItems(arrInt)} \n\n\n");
}   // void Task34()

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void Task36()
{
    int SummOddItems(int[] arrInt)
    {
        int len = arrInt.Length, summOdd = 0;
        for (int i = 1; i < len; i+=2){
            summOdd += arrInt[i];
        }
        return summOdd;
    }

    string tsk36 = " \n" 
    + "Задача 36: Задайте одномерный массив, заполненный случайными числами.  \n"
    + "Найдите сумму элементов, стоящих на нечётных позициях. \n";

     Console.Write( $" {tsk36} \n");

    int ln = promtInt(" длину массива ");
    int[] arrInt = FillArrayInt(ln, -99, 99); 

    Console.WriteLine(
        $"[{string.Join(", ", arrInt)}] \n " 
        + $" сумма : {SummOddItems(arrInt)} \n\n\n");
}   // void Task36()

/*
Задача 38: Задайте массив вещественных(double) чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76

inputValue = Math.Round(inputValue, 2);
!! округление до одного знака
 //  Math.Round({3.45m}, 1, MidpointRounding.ToEven)
*/
void Task38()
{
    string tsk38 = " \n" 
    + "Задача 38: Задайте массив вещественных(double) чисел. \n"
    + "Найдите разницу между максимальным  \n"
    + "и минимальным элементов массива. \n";

     Console.Write( $" {tsk38} \n");
    int iLn = promtInt(" длину вещественного массива ");
    double[] arrDbl = FillArrayDouble(iLn);

    for (int i = 0; i < arrDbl.Length ; i++){  // set 1 digit after point
        arrDbl[i] = Math.Round(arrDbl[i], 1);       
    }

    double diffArr = arrDbl.Max() - arrDbl.Min();
    Console.WriteLine(
        $"[{string.Join("; ", arrDbl)}] \n " 
        + " разницу между максимальным  "
        + $"и минимальным  : {diffArr} \n\n\n");
}   // void Task38()

Task34();
Task36();
Task38();
Console.WriteLine("https://gb.ru/lessons/305490/homework \n Hello, World!");