// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow
Console.Clear();
Console.WriteLine ("Введите число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите степень");
int b = Convert.ToInt32 (Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
    result = result * a;
Console.WriteLine("");    
Console.WriteLine ($"Число {a} в степени {b} = {result}");