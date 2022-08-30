// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write($"Введи число М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int AmountPositive(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

void PrintArray(int[] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if(i < arrayNumbers.Length - 1) Console.Write(arrayNumbers[i] + ",");
        else Console.Write(arrayNumbers[i] + " ");
    }
}

InputNumbers(m);

PrintArray(arrayNumbers);

Console.WriteLine($"-> {AmountPositive(arrayNumbers)} ");