﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значения: "); 
int b1;
b1 = Convert.ToInt32(Console.ReadLine());
int k1;
k1 = Convert.ToInt32(Console.ReadLine());

int b2;
b2 = Convert.ToInt32(Console.ReadLine());
int k2;
k2 = Convert.ToInt32(Console.ReadLine());

GetPoint(b1, k1, b2, k2);

static void GetPoint(double b1, double k1, double b2, double k2)
{      
    double y = (k1 * (b2-b1)/(k1-k2)) + b1;
    double x = (b2 - b1) / (k1 -k2);
    Console.WriteLine("(" + x + ";" + y + ")");
}