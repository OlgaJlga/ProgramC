//  Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine ("Ведите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ведите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine("Первое число больше второго - " + num1);
}
else Console.WriteLine("Второе число больше первого - " + num2);
