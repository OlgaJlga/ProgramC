// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество чисел в массив");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(new Random().Next(0,100001));
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