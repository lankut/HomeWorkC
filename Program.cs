﻿// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Create2DArray (int m, int n, int minV, int maxV)
{
    int [,] newArray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minV, maxV);
    }
    return newArray;
}

int [,] Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int [,] SortingDown (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        bool sorted = false;
        while(!sorted)
        {
            sorted = true;
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {    
                if (array[i,j]<array[i,j+1]) 
                {
                    int temp = array[i,j]; 
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp; 
                    sorted = false;            
                }
            }
        }
    }
    return array;
}


int [,] mass = Create2DArray(4, 4, 10, 99);
Show2DArray(mass);

Show2DArray(SortingDown(mass));

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] Create2DArray (int m, int n, int minV, int maxV)
{
    int [,] newArray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minV, maxV);
    }
    return newArray;
}

int [,] Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void Find (int [,] array)
{
    int imin = 0;
    int min = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            if (i == 0)
                {    
                sum = sum + array[i,j];
                min = min + array[i,j];
                }
            else 
                sum = sum + array[i,j];
        }            
        if (sum < min)
        {
            min = sum;
            imin = i;
        }
        sum = 0;
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == imin)
            Console.Write(array[i,j]+" ");
    }    
}

int [,] mass = Create2DArray(4, 6, 10, 99);
Show2DArray(mass);

Find(mass);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int [,] Create2DArray (int m, int n, int minV, int maxV)
{
    int [,] newArray = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            newArray[i,j] = new Random().Next(minV, maxV);
    }
    return newArray;
}

int [,] Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int [,] Mult (int [,] array1, int [,] array2)
{
    int [,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            
                newArray[i,j] = array1[i,j]*array2[i,j];
        }
    }    
    return newArray;
}


int [,] mass1 = Create2DArray(4, 4, 1, 20);
int [,] mass2 = Create2DArray(4, 4, 1, 20);
Show2DArray(mass1);
Show2DArray(mass2);
Show2DArray(Mult(mass1, mass2));