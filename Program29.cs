// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int min = ReadInt("Введите минимальное число: ");
int max = ReadInt("Введите максимальное число: ");
int []array = new int[8];
for (int i = 0; i <8; i ++)
{
    array[i] = new Random().Next(min, max+1);
}
Console.WriteLine(string.Join(" , " , array));