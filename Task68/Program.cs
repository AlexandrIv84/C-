// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int a, int b)
{
if (a == 0)
    return b + 1;
if (b == 0)
    return Akkerman(a-1, 1);
return Akkerman(a - 1, Akkerman (a, b - 1));
}

Console.Clear();
Console.WriteLine("Введите M");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {Akkerman(n, m)}");