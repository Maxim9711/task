// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Кубы чисел до {num}");
for (int i = 1; i <= num; i++)
    Console.Write($"{i*i*i} ");