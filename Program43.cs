// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {(-b2 + b1)/(-k1 + k2)}, Y: {k2 * ((-b2 + b1)/(-k1 + k2)) + b2}");