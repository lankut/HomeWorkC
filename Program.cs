﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int num, int degree)
{
    int res = num;
    for (int i = 1; i < degree; i++)
    {
        res=res*num;
    }
   return res;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите в какую степень возвести число: ");
int degree = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(num, degree);   

if (degree>0)
{
    Console.WriteLine(result);    
}
else 
    Console.WriteLine("Число возведения в степень не натуральное!");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumSumm(int number)
{
    int result = 0;
    while (number !=0)
        {
            result = result + number%10;
            number = number/10;
        }
        return result;
}

Console.Write("Введите число для подсчета суммы: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = NumSumm(num);
Console.WriteLine($"Сумма чисел входящих в число {num} равняется {num1}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Array(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-100, 100);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();    
}

int[] num1 = Array(8);
ShowArray(num1);
