// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введи номер дня недели: ");
int numb = int.Parse(Console.ReadLine());
if (numb == 6 || numb == 7)
{
    Console.WriteLine("Это выходной");
}
else if (numb < 6)
{
    Console.WriteLine("Это будний день");
}
else if (numb > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
