// Напишите программу, которая на вход принимает радиус круга и 
// находит его площадь округленную до целого числа, необходимо вывести 
// максимальную цифру в полученном округлённом значении площади круга


Console.Clear();
Console.WriteLine("Введите значение Радиуса:");
double r = Convert.ToDouble(Console.ReadLine());

double square = Math.PI * r * r;
Console.WriteLine(" Площадь круга =, " + square, Math.Round(square, 0));