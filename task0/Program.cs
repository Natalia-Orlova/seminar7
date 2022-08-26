// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: 
// Amn = m+n.
// Выведите полученный массив на экран.

int[,] CreateMatrixSumIndex(int row, int col) // созд 2мерного массива
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

int[,] array2D = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2D);