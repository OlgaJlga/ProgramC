// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи пробела.
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
int count = 0; 
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
