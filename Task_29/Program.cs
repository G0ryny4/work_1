// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.Clear();

int[] array = GetRandomArray(8);
WriteArrayConsole(array);

int [] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = rnd.Next(0, 10);
    }
    return arr;
}

void WriteArrayConsole(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length -1)
            Console.Write(",");
    }
    Console.WriteLine("]");
}

