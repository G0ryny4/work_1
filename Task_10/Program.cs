// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int num = new Random().Next(100, 1000);

int result = ShowSecond(num);

int ShowSecond(int num)
{
    int first = num / 10;
    int second = first % 10;
    return second;
}

Console.WriteLine($"{num} -> {result}");
