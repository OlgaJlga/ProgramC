// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите количество чисел в массив");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];
    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0,10001);
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