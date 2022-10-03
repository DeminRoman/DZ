//Напишите программу, которая задаёт массив из n элементов, 
//которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево,
//или вправо на 1 позицию.
//[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
//[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

Console.WriteLine("Введите размер массива N:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массив: ");
Console.WriteLine();
PrintArray(array);
ArrayRotateRight(array);
PrintArray(array);
ArrayRotateLeft(array);
PrintArray(array);


void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
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
void ArrayRotateRight(int array[], int size)
{
    register int temp = array[--size];
    while (size > 0) array[size--] = array[size - 1];
    array[0] = temp;
}
void ArrayRotateLeft(int array[], int size)
{
    register int i, temp = array[0];
    for (i = 0, size--; i < size; i++) array[i] = array[i + 1];
    array[size] = temp;
}
