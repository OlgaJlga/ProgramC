﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int number = ReadInt32("Введите число: ");
int count = number.ToString().Length;
Console.Write(Array(number, count));
int ReadInt32(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Array(int a, int b)
{
int result = number;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет в числе - ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}