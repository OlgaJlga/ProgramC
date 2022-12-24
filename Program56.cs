//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размеры массива : ");
int mass = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[mass, mass];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int min= Int32.MaxValue;
int indexLine = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        indexLine++;
    }
}
Console.WriteLine($"Строка с наименьшей суммой елементов под номером: {indexLine}, с суммой елементов равной: {min}");
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10000, 10000);
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