// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0 && m < 0)
{
 Console.WriteLine("Ввели не положительное число");
}
else
Console.WriteLine($"Akkerman({m}, {n}) = {Akkerman(m, n)}");
int Akkerman(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  } 
  else if ((m > 0) && (n == 0)) 
  {
  return Akkerman(m-1, n);
  } 
  else if ((m > 0) && (n > 0)) 
  {
  return Akkerman(m-1, Akkerman(m,n-1));
  } 
  else 
  {
  return 0;
  }
}