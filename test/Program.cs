string[,] Pascal(int n)
{
    int value = 1;
    string[,] pascal = new string[n, n];
    for (int i = 1; i <= n; i++)
    {
        value = 1;
        for (int j = 1; j <= i; j++)
        {
            pascal[i - 1, j - 1] = Convert.ToString(value);
            value = value * (i - j) / j;
        }
    }
    return pascal;
}

void PrintMatrix(string[,] matrix)
{
    Console.Clear();
    int line = default;
    if (matrix.GetLength(1) <= 20) line = (int)Math.Sqrt(matrix.GetLength(1)) - 1;
    else line = (int)Math.Sqrt(matrix.GetLength(1));

    int left = (matrix.GetLength(1) - 1) * line;
    for (int i = 0, k = 0; i < matrix.GetLength(0); i++, k += line)
    {
        for (int j = 0, l = 0; j < matrix.GetLength(1); j++, l += line)
        {
            if (matrix[i, j] == null) break;
            Console.SetCursorPosition(left + l + l - k, i + 1);
            Console.Write(matrix[i, j]);

        }
    }
}

Console.Write("Внимание если вводите число больше 20 уменьшите размер шрифта Терминала\n" +
    "Введите количество строк ");
int numberN = Convert.ToInt32(Console.ReadLine());
PrintMatrix(Pascal(numberN));