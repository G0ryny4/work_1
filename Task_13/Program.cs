// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int num = new Random().Next(10, 100000);

int ShowThird(int num)
{if (num < 100) return 0;
 while (num > 1000)
    {
       num = num / 10;
    }
    int third = num % 10;

    return third;
}

int result = ShowThird(num);

if (result == 0) Console.WriteLine($"{num} -> третьей цифры нет");

else Console.WriteLine($"{num} -> {result}");