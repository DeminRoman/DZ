// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.Clear();
Console.WriteLine("Введите координату X1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z2:");
int z2 = int.Parse(Console.ReadLine());

double Length = Math.Sqrt(Math.Pow((x1 - x2), 2)
                          + Math.Pow((y1 - y2), 2)
                          + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве = {Length}", 
Math.Round(Length, 2));

