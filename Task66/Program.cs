// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int sum(int a, int b)
{
if (a == b)
return a;
return sum(a, b - 1) + b;
}

Console.Clear();
Console.WriteLine("Введите M");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cумма чисел от M до N: {sum(n, m)}");