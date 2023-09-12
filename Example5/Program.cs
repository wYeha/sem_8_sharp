// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillMatrix(int[,] matrix)
{
    int flag = 4, i = 0, j = 0, count = 1;
    while (flag > 0)
    {
        for (j; j < flag; j++)
        {
            matrix[i, j] = count;
            count++;
        }
        for (i; i < flag; i++)
        {
            matrix[i, j] = count;
            count++;
        }
        for (j; j > 4 - flag; j--)
        {
            matrix[i, j] = count;
            count++;
        }
        flag--;
        for (i; i > 4 - flag; i--)
        {
            matrix[i, j] = count;
            count++;
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
            Console.Write($"{matrix[i, j],3} ");
        }

        Console.WriteLine();
    }
}


int[,] array = new int[4, 4];
PrintMatrix(FillMatrix(array));