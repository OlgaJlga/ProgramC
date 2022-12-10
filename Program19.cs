//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
var len = number.Length;
if (len == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - Не палиндром");
    }
}
else
{
 Console.WriteLine($"{number} - не является пятизначным числом");
}