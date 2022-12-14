// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine ("Введите количество чисел");
int m = Convert.ToInt32 (Console.ReadLine());
int count = 0;
for(int i = 0; i < m; i++)
    {
        Console.WriteLine ($"Введите число {i+1}:");
    int n = Convert.ToInt32 (Console.ReadLine());
    if (n > 0) count++;
    }
Console.WriteLine ($"Количество чисел больше 0 : {count}");
