// Задача 50. Напишите программу, которая на вход принимает позиции
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1, 10);
PrintArray(array);

Console.WriteLine("Введите координаты");
int rowCount1 = Convert.ToInt32(Console.ReadLine());
int columnCount1 = Convert.ToInt32(Console.ReadLine());

if (rowCount1 > rowCount && columnCount1 > columnCount)
    Console.WriteLine($"{rowCount1}{columnCount1} -> такого числа в массиве нет");
else
{
    object c = array.GetValue(rowCount1, columnCount1);
    Console.WriteLine(c);
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}


void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}




