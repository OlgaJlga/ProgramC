// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = ReadInt32("Введите 3-х значное число:");
int amount = number.ToString().Length;
if (amount < 3 || amount > 3)
{
 Console.WriteLine("Это не 3-х значное число");
}
else
{
 Console.WriteLine(InCenter(number));
}
int ReadInt32(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
 int result = ((a / 10) % 10);
    return result;
}