// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[n];
int count =0;
for (int i = 0; i < n; i++) 
    {
    array[i] = new Random().Next(100, 1000);
    if (array[i] %2 == 0) //Разрешено всё, что не запрещенно, поэтому считаем сразу)
        count++;
    }
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во четных элементов массива {count}");