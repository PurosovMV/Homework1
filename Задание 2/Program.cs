/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Программа находит максимальное из трёх чисел");
Console.WriteLine("Введи через пробел три числа ");
string[] i = Console.ReadLine().Split(' ');
int a = Convert.ToInt32(i[0]);
int b = Convert.ToInt32(i[1]);
int c = Convert.ToInt32(i[2]);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write($"{a}, {b}, {c} -> {max}");