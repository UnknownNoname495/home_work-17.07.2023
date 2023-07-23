// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int colums = 4;
int[,] matrix = new int[rows, colums];
GetMatrix(matrix);
PrintMatrix(matrix);


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetMatrix(int[,] matr)
{
    int count = 1;
    for (int i = 0; i < colums; i++) matr[rows - rows, i] = count++;
    for (int i = 1; i < rows; i++) matr[i, colums - 1] = count++;
    for (int i = 2; i >= colums - colums; i--) matr[rows - 1, i] = count++;
    for (int i = 2; i > (rows - rows); i--) matr[i, colums - colums] = count++;
    for (int i = 1; i < colums - 1; i++) matr[(rows - rows) + 1, i] = count++;
    for (int i = 2; i >= (colums - colums) + 1; i--) matr[(colums - colums) + colums / 2, i] = count++;
}

// Решение крайне забавное, максимально костыльное, но с размерами 4 на 4 работает))