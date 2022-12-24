// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи стоп-слова.
string newstr = ""; 
for (int i = 0; ;i++) 
{ 
Console.WriteLine($"Введите число {i + 1}, для прекращения ввода введите stop"); 
string str = Console.ReadLine(); 
int num = Convert.ToInt32(str);
newstr = newstr + str; 
if (str == "stop") 
{ 
   break; 
} 
} 
int[] numbers = new int[newstr.Length-4]; 
int sum=0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");
int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
void PrintArray(int[] array)
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ");
}