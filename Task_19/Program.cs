// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int revers = 0;
int digit = 0;

string Palindrome(int num)
{
    while (num > 0)
    {
        digit = num % 10;
        revers = revers * 10 + digit;
        num = num / 10;

    }
    if (temp == revers) return "ДА";
    return "НЕТ";
}

string result = Palindrome(num);

Console.WriteLine($"{num} -> {result}");
