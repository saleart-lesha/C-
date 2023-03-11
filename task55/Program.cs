// Задача 55:**Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы.
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2, 10);
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

int[,] ChangeMatrixRowColumn(int[,] matrixIn)
{
    int[,] newMatrix = new int[matrixIn.GetLength(1), matrixIn.GetLength(0)];
    for (int i = 0; i < matrixIn.GetLength(1); i++)
    {
        for (int j = 0; j < matrixIn.GetLength(0); j++)
        {
            newMatrix[i, j] = matrixIn[j, i];
        }
    }
    return newMatrix;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
int[,] useMatrix = ChangeMatrixRowColumn(matrix);
System.Console.WriteLine();
PrintMatrix(useMatrix);



