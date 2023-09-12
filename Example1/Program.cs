//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Random rnd = new Random();

int[,] FillMatrix(int[,] matrix)
{
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[,] matrix, int row)
{
    int temp;
    int n = matrix.GetLength(1);
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (matrix[row, j] < matrix[row, j + 1])
            {
                temp = matrix[row, j];
                matrix[row, j] = matrix[row, j + 1];
                matrix[row, j + 1] = temp;
            }
        }
    }
}


int[,] matrix = new int[5, 6];
PrintMatrix(FillMatrix(matrix));
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    BubbleSort(matrix,i);
}

PrintMatrix(matrix);
