// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32 (Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int i = 1; i < n; i+=2) //Четные не интересуют, даже заполнять их не буду)
    {
    array[i] = new Random().Next(0, 100);
    sum = sum + array[i];
//    Console.WriteLine (sum);  
    }
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");