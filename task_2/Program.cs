// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int minRand = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxRand = Convert.ToInt32(Console.ReadLine());

if (rows == colums)
{
    Console.WriteLine("Матрица не прямоугольная!");
    return;
}
Console.WriteLine();

int[,] matrixArray = GetMatrix(rows, colums, minRand, maxRand);
PrintMatrix(matrixArray);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
     Console.WriteLine("Массив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int RowSum(int[,] matr, int i)
{
    int sum = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sum += matr[i, j];
    }
    Console.WriteLine($"В строке {i + 1} сумма элементов: {sum}");
    return sum;
}
Console.WriteLine();

int minSum = 0;
int sum = RowSum(matrixArray, 0);
for (int i = 1; i < matrixArray.GetLength(0); i++)
{
    if (sum > RowSum(matrixArray, i))
    {
        sum = RowSum(matrixArray, i);
        minSum = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Строка c наименьшей суммой элементов ({sum}): {minSum + 1}");
