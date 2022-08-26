// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // созд 2мерного массива
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4},");
        else Console.Write($"{matrix[i,j], 3} ");
    }
    Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2D);