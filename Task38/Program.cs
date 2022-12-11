// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32 (Console.ReadLine());
double[] array = new double[n];
double max = 0;
double min = 0;
for (int i = 0; i < n; i++)
            // Хотелось немного округлить, сразу при заполнении массива, до 5 знаков после запятой, . Каков синтаксис? Пытался, но не вышло(
        array[i] = new Random().NextDouble() * 100;
max = array.Max ();
min = array.Min ();
//Console.WriteLine($"Макс: {max}");
//Console.WriteLine($"Мин: {min}");
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница:{max-min}");