// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(1, a+1);
int i = 1;
while ( i <= number)
 {
    if (i % 2 != 1)
     {
         Console.Write(i + ", ");
     }
     i ++;
 }