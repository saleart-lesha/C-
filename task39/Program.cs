// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

int[] ReverseArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
array = ReverseArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");


