// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 && m < 1)
{
 Console.WriteLine("Ввели не положительное число");
}
else
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int Akkerman(int m, int n)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
