// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write($"{matrix[i, j]} \t"); 
        }
        Console.WriteLine();

    }
}

void SortElementMatrix(int[, ] matrix)
{   
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) ; j++)
        {
            for (int k = j ; k < matrix.GetLength(1) ; k++)
            {
                if (matrix[i, j] < matrix[i, k] )
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();

    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
SortElementMatrix(matrix);