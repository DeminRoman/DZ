// Напишите программу, которая задаёт массив из 10 элементов,
// которые необходимо заполнить случайными значениями в диапазоне 
// от -10 до 10 и найти максимальное значение среди них
//[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
//[-5, 1, -9, 6, -7, -2, -3, -4, -6, 1]-> 6
//[-7, 2, 4, 6, -7, 7, -3, -4, -2, 1]-> 7

Console.Clear();

int[] Random(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 9);
    }

    return array;
}

int[] array = new int[10];
array = Random(array);

Console.Write(String.Join(",", array));
Console.WriteLine();

int max = Int32.MinValue;
for (var i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(($"Максимальное число в массиве: {max}"));
