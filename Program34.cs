// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Массивы: ");
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++; 
Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write(" ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}