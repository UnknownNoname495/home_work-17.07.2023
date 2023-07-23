// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows = 2;
int columns = 2;
int[,] firstMatrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] multiplyMatrix = new int[rows, columns];

GetMatrix(firstMatrix);
PrintMatrix2D(firstMatrix);

Console.WriteLine();

GetMatrix(secondMatrix);
PrintMatrix2D(secondMatrix);

Console.WriteLine();

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        multiplyMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            multiplyMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintMatrix2D(multiplyMatrix);

void GetMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}