// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int a = ReadInt("Введите первое число: ");
int b = ReadInt("Введите второе число: ");
int step = a;
for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);