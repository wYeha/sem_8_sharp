// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillMatrix(int rows, int cols)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
        }
    }
    return matrix;
}

int rowsA = 4;
int colsA = 4;
int rowsB = 4;
int colsB = 4;

int[,] matrixA = FillMatrix(rowsA, colsA);
int[,] matrixB = FillMatrix(rowsB, colsB);

if (colsA != rowsB)
{
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    return;
}

int[,] resultMatrix = new int[rowsA, colsB];

for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        for (int k = 0; k < colsA; k++)
        {
            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        Console.Write($"{resultMatrix[i, j], 5}");
    }
    Console.WriteLine();
}