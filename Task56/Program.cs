// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

void InputMatrix(int[, ] matrix)
{
    int sum = 0, numberRow = 0, minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            sum += matrix[i, j];
            if (i == 0)
                minSum = sum;
            Console.Write($"{matrix[i, j]} \t");
            
        }
        Console.Write($"      Сумма элементов в строке: № {i+1 }: {sum} ");
        Console.WriteLine();
        
        if (minSum > sum)
        {
            minSum = sum;
            numberRow = i;
                    }
        sum = 0;
    }
    Console.WriteLine("");
    Console.WriteLine($" Номер строки с наименьшей суммой элементов: {numberRow + 1}");
}

// Проверку на "прямоуголбность" массива не стал делать, вводим любой размер

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine();