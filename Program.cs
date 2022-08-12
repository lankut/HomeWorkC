﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}
   
int[] InputUser(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите элемент массива (положительный или отрицательный) под индекcом {i}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i]>0) count++;
    }
    return count;
}

int[] Array = InputUser(4);

int a = Count(Array);

ShowArray(Array);
Console.WriteLine($"Количество положительных значений массива {a}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;

Console.WriteLine($"Точка пересичения двух прямых {x}, {y}");