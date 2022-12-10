// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите число: ");
int sum = 0;
while (number > 0)
{
int num = number % 10;
number = number / 10;
sum = sum + num;
}
Console.WriteLine($"Cумма всех цифр в числе равна: {sum} ");