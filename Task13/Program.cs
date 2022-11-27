// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > -100 && n < 100)
    Console.WriteLine (" Нет третьей цифры в введенном числе");
else
    { 
    while (n > 1000 || n < -1000)
        n=n/10;
    if (n < 0)
        n=n*(-1);
    Console.WriteLine ($"Третья цифра числа: {n % 10}");
    }
