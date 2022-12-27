// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int o = 1;
if (N < 1)
{
 Console.WriteLine("Ввели не положительное число");
}
else
Console.WriteLine(NaturalNumber(N, o));
int NaturalNumber(int N, int o)
{
 if (N == o)
 return N;
 else
 Console.Write($"{NaturalNumber(N, o + 1)}, ");
 return o;
}