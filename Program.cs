﻿// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums (int m, int n)
{
    if (m>n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n != m) ShowNums(m, n-1);
    Console.Write(n + " ");
}

Console.Write("Введите число M: "); 
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: "); 
int numN = Convert.ToInt32(Console.ReadLine());

ShowNums (numM, numN);
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Summ (int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n != m) return n + Summ(m, n - 1);
    return n;
}

Console.Write("Введите число M: "); 
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: "); 
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Summ(numM, numN));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    
    else if (m > 0 && n == 0) 
    return Akkerman(m - 1, 1);
    
    else if (m > 0 && n > 0) 
    return Akkerman(m-1, Akkerman(m, n-1));
    
}

Console.Write("Введите число M: "); 
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: "); 
int numM = Convert.ToInt32(Console.ReadLine());

Akkerman (numN, numM);
Console.WriteLine();