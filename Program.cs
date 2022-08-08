﻿
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 999);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);

int DoubleMass(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
        if (array[i]%2 == 0)
        count++;
    return count;
}

int count2 = DoubleMass(array);
Console.WriteLine($"Количество четных чисел в массиве {count2}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(10, 99);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);

int Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
        summ = summ+array[i];
    return summ;
}


int count2 = Summ(array);
Console.WriteLine($"Сумма нечетных индексов массива равна {count2}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(0, 99);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);

int Find (int[] array)
{
    int diff = 0;
    int min = array[0];
    int max = array[0];
    for (int i = 1; i<array.Length; i++)
        if (min > array[i])
            min = array[i];
    for (int i = 1; i<array.Length; i++)
        if (max < array[i])
            max = array[i];
    diff = max - min;
    return diff;
}

int count2 = Find(array);
Console.WriteLine($"Разница между максимальным и минимальным числом равна {count2}");