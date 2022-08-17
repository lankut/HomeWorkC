﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными
// числами.

double [,] Create2DArray (int m, int n, int minVal, int maxVal)
{
    double [,] newArray = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minVal, maxVal) + new Random().NextDouble();
    }    
    return newArray;
}

void Show2DArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double [,] array = Create2DArray (5, 5, -13, 13);
Show2DArray(array); 

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] Create2DArray (int m, int n, int minVal, int maxVal)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minVal, maxVal);
    }    
    return newArray;
}

void Show2DArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowLocation (int [,] array, int x, int y)
{
    if (x > array.GetLength(0) || y > array.GetLength(1))   
                Console.WriteLine("Такого элемента нет");
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==x && j==y)
                Console.WriteLine($"Значение элемента в массиве {array[i,j] }");
        }
    }
}

Console.Write("Введите расположение строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите расположение столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2DArray (5, 5, 0, 50);
Show2DArray(array);

ShowLocation(array, m, n);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2DArray (int m, int n, int minVal, int maxVal)
{
    int [,] newArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minVal, maxVal);
    }    
    return newArray;
}

void Show2DArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Average(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j,i];
        }
        Console.Write($"{sum/array.GetLength(1)} ");
    }
    return array;
}
int [,] array = Create2DArray (3, 3, 0, 9);
Show2DArray(array);

Average(array);