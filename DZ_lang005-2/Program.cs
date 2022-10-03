//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

Console.Clear();

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int sum = 0;

for (int j = 0; j < array.Length; j++)

{
    if (j % 2 == 1)
        sum = sum + array[j];
}

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях= {sum}");


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
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