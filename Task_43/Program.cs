﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
// int SearchX = 0; 
// int SearchY = 0; 

if ((k1 == k2) && (b1 == b2))
    Console.Write("Прямые совпадают");
else if (k1 == k2)
    Console.Write("Прямые параллельны");

else
{
    double SearchX = (b2 - b1) / (k1 - k2);
    double SearchY = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"Координаты точки пересечения прямой: [{SearchX};{SearchY}]");
}
