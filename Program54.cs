//  Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк : ");
int Lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int Columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[Lines, Columns];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив до изменения");
PrintArray(numbers);
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] > numbers[i, z + 1]) 
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 array[i, j] = Convert.ToInt32(new Random().Next(-10000, 10000));
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}