// Напишите программу, которая задаёт массив из 10 элементов,
// которые необходимо заполнить случайными значениями в диапазоне 
// от -10 до 10 и найти максимальное значение среди них
//[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
//[-5, 1, -9, 6, -7, -2, -3, -4, -6, 1]-> 6
//[-7, 2, 4, 6, -7, 7, -3, -4, -2, 1]-> 7

Console.Clear();

int[] Random01(int[] array_local)
{
    Random rnd = new Random();
    for (int i = 0; i < array_local.Length; i++)
    {
        array_local[i] = rnd.Next(-10, 9);
    }

    return array_local;
}

int[] array = new int[10];
array = Random01(array);

Console.Write(String.Join(",", array));
