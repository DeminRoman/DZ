// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите число A");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("Число A = " + num_A + " больше чем Число B =" + num_B);
}
else
{
    Console.WriteLine("Число B =" + num_B + " больше чем Число A =" + num_A);
}
