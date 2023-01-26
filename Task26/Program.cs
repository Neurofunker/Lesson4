﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;

int result = CountDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {result} ");

int CountDigit(int num)
{
    int count = 1;
    while (num > 9)
    {
        num = num / 10;
        count++;
    }
return count;
}