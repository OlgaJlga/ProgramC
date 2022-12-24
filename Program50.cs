// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int z = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [100,100];
FillArrayRandomNumbers(numbers);
if (x > numbers.GetLength(0) || z > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {x} строки и {z} столбца равно {numbers[x-1,z-1]}");
}
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10000, 1000);
            }   
        }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(" "); 
    }
}
