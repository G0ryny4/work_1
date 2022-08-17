// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int GetPower(int numberA, int numberB)
{
    int power = 1;

    for (int i = 0; i < numberB; i++)
    {
        power = power * numberA;
    }
    return power;
}

int result = GetPower(numA, numB);
Console.WriteLine($"число {numA} в степени {numB} = {result}");
