// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine ("Введите координаты точки А (x,y,z):");
double a_x = Convert.ToDouble(Console.ReadLine());
double a_y = Convert.ToDouble(Console.ReadLine());
double a_z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите координаты точки B (x,y,z):");
double b_x = Convert.ToDouble(Console.ReadLine());
double b_y = Convert.ToDouble(Console.ReadLine());
double b_z = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow (a_y -b_y, 2) + Math.Pow(a_z - b_z, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве: {Math.Round (result , 2)}");
