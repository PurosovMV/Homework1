/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Программа находит максимальное из введённых чисел");
Console.WriteLine("Напиши первое число (a): ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напиши второе число (b): ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write($"a = {a}; b = {b} -> max = {max}");


