// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < -999 || (n > -100 && n < 100) || n > 999)
{
Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n < 0)
    n = n *(-1);
Console.WriteLine ((n % 100) / 10);