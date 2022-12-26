// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите M :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N :");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {M} до {N} = {NaturalSum(M, N)}");
int NaturalSum(int M, int N)
{
    if (M == N)
        return N;
    return N + NaturalSum(M, N - 1);
}