// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int num = new Random().Next(1, 8);

int WeekDay(int num)
{
    if ( num < 6) return 0;
    else return 1;
}

int result = WeekDay(num);

if (result == 0) Console.WriteLine($"{num} -> нет");

else Console.WriteLine($"{num} -> да");