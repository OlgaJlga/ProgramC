// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
if (a1==1)
{Console.WriteLine("Понедельник");}
if (a1==2)
{Console.WriteLine("Вторник");}
if (a1==3)
{Console.WriteLine("Среда");}
if (a1==4)
{Console.WriteLine("Четверг");}
if (a1==5)
{Console.WriteLine("Пятнца");}
if (a1==6)
{Console.WriteLine("Суббота, выходной");}
if (a1==7)
{Console.WriteLine("Воскресенье, выходной");}
if (a1>7||a1<1)
{Console.WriteLine("В недели семь дней");}