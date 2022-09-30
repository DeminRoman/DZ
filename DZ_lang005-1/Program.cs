//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        count++;

Console.WriteLine("Количество чётных чисел в массиве:" + count);

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

