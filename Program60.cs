// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int mas1 = InputInt("Введите размеры 1-го массива : ");
int mas2 = InputInt("Введите размеры 2-го массива : ");
int mas3 = InputInt("Введите размеры 3-го массива : ");
int max = 10000;
if (mas1 * mas2 * mas3 > max)
{
    Console.Write("Массив слишком большой");
    return;
}
int[,,] resultNum = Create3DMassive(mas1, mas2, mas3);
for (int i = 0; i < resultNum.GetLength(0); i++)
{
    for (int j = 0; j < resultNum.GetLength(1); j++)
    {
        for (int k = 0; k < resultNum.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNum[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[max];
    int num
     = 10000;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }
    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}