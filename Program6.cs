// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
int d = 2;
int y = x % d;
if (y==0)
{
    Console.WriteLine("Четное");
}
else Console.WriteLine("Нечетное");