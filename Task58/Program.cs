// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t"); 
        }
        Console.WriteLine();

    }
}

void ResoultMatrix(int[, ] resMatrix, int[, ] matrix, int[, ] matrix2)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            resMatrix[i, j] = matrix[i, j] * matrix2[i, j];
            Console.Write($"{resMatrix[i, j]} \t"); 
        }
        Console.WriteLine();

    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[,] matrix2 = new int[coord[0], coord[1]];
int[,] resMatrix = new int[coord[0], coord[1]];

Console.WriteLine("Массив 1:");
InputMatrix(matrix);

Console.WriteLine("");
Console.WriteLine($"Массив 2: ");
InputMatrix(matrix2);

Console.WriteLine("");
Console.WriteLine("Полученный массив: ");
ResoultMatrix(resMatrix, matrix, matrix2);