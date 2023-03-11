// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] DeleteComponentMin(int[,] matrix)
{
    int indexI = 0;
    int indexJ = 0;
    int min = matrix[0,0];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < min)
            {
                min = matrix[i,j];
                indexI = i;
                indexJ = j;
            }
        }
    }

    int[,] resultMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int flagI = 0;
    int flagJ = 0;
    
    for(int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for(int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if(i >= indexI)
            {
                flagI = 1;
            }
            else
            {
                flagI = 0;
            }
            
            if(j >= indexJ)
            {
                flagJ = 1;
            }
            else
            {
                flagJ = 0;
            }
            resultMatrix[i,j] = matrix[i+flagI, j + flagJ];
        }
    }
    return resultMatrix;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] resultMatrix = DeleteComponentMin(matrix);
PrintMatrix(resultMatrix);