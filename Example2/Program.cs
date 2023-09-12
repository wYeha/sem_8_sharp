// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rnd = new Random();

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-20, 20);
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

int SmallestStringSumm(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

int[,] array = new int[5, 4];
PrintMatrix(FillMatrix(array));
Console.WriteLine($"Строка с наименьшей суммой элементов под индексом {SmallestStringSumm(array)}");
