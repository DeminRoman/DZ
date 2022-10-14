// Задача 68: Задайте значения M и N. Напишите программу, которая 
// найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7-> 7

Console.Clear();

Console.WriteLine("Введите число M: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Наибольший общий делитель = " + GCD(M,N));

int GCD(int M, int N)
{
    if (M % N == 0)
        return N;
    if (N % M == 0)
        return M;
    if (M > N)
        return GCD(M % N, N);
    return GCD(M, N % M);
}