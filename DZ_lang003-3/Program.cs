// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
    Console.Write(Math.Pow(i, 3) + " ");

