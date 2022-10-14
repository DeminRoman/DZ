// Задача 64: Задайте значения N и M. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5-> 2, 4
// M = 4; N = 8-> 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Чётные числа:");
Even(N, M);
Console.WriteLine();


void Even(int N,int M)
{
    if (M < N)
    {
        return;
    }

    if (M % 2 == 0)
        Even(N, M - 2);
    else
        Even(N, M - 1);

    if (M % 2 == 0)
    {
        Console.Write(M + " ");
    }
}                 