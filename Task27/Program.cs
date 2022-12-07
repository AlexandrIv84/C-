// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine ("Введите число");
string? n = Console.ReadLine();
int sum =0;
for (int i =0; i < n.Length; i++)
    sum = sum + int.Parse(n[i].ToString());
Console.WriteLine($"Сумма цифр данного числа: {sum}");