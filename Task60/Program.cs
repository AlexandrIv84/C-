// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputArray(int[, , ] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++ )
            {
                array[i, j, k] = count;
                Console.WriteLine($"{array[i, j, k]} c координатами({i},{j},{k}) ");
                count++;
            }
                     
        }
        Console.WriteLine();

    }
}

int[, , ] array = new int[2, 2, 2];
Console.WriteLine ("Элементы массива:");
InputArray (array);