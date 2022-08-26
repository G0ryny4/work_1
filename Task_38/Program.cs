// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();

double[] CreateArrayRndDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * 100;
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
}

double GetDiffMaxMin(double[] array)
{
    
    double min = array[0];
    double max = array[0];
    double result = 0;
    

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];    
          
              
    } 
    
    result = (max - min);  

    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndDouble(5);
PrintArray(array);
double getDiff = GetDiffMaxMin(array);
Console.WriteLine($" -> {getDiff}");