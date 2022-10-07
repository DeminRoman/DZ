//Задача 10:Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int num2 = ((num / 10) % 10);
    Console.WriteLine($"Вторая цифра:{num2} ");
}