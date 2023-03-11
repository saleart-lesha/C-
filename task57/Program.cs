// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
        
    }
    return arr;
}

int[] FrequencyDictionary(int[,] matrix)
{
    int [] temp = new int [10];
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {            
            temp[matrix[i,j]]++;       
        }
    }
    return temp;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
int[] indexArray = FrequencyDictionary(matrix);
for(int i = 0; i < indexArray.Length; i++)
{
    if(indexArray[i] != 0) // != - неравно // == - равно
    {
        Console.WriteLine($"Число {i} встретилось {indexArray[i]} раз");
    }
}