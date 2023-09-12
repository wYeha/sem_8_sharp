// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4; 
int[,] array = new int[n, n];

int value = 1; 
int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

while (value <= n * n)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        array[minRow, i] = value++;
    }
    minRow++;

    for (int i = minRow; i <= maxRow; i++)
    {
        array[i, maxCol] = value++;
    }
    maxCol--;

    for (int i = maxCol; i >= minCol; i--)
    {
        array[maxRow, i] = value++;
    }
    maxRow--;

    for (int i = maxRow; i >= minRow; i--)
    {
        array[i, minCol] = value++;
    }
    minCol++;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j], 3} ");
    }
    Console.WriteLine();
}