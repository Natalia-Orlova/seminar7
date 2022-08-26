// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

void ChangeMatrixEvenIndex(int [,] matrix) // созд 2мерного массива
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j]; 
        }
    }
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

int[,] array2D = CreateMatrixRndInt(3, 4, -3, 3);
PrintMatrix(array2D);

Console.WriteLine();

ChangeMatrixEvenIndex(array2D);
PrintMatrix(array2D);