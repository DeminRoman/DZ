// Задача 8:Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();


Console.Clear();

Console.Write("Number: ");

int number = int.Parse(Console.ReadLine());

int num = 1;

while (num <= number)
{
    if (num % 2 != 1)
    {
    Console.Write(num + "  ");
    }
    num += 1;
}

