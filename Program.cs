﻿//Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

void Palindrom (int num)
{
    
    if (num > 9999 && num < 100000)
    {
        int num1 = num % 100;
        int num2 = num / 1000;
        int num3 = num1 % 10;
        int num4 = num2 /10;   
        int num5 = num1 / 10;
        int num6 = num2 % 10;

        if (num3 == num4 && num5 == num6)
        {
            Console.WriteLine("Число является палиндромом");  
        }
        else Console.WriteLine ("Число не является палиндромом");
    }
    else Console.WriteLine ("Число не соответствует пятизначному");
}

Console.Write("Введите пятизначное число: ");
int res = Convert.ToInt32(Console.ReadLine());
Palindrom(res);

// Задача 21 Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

double Lenth(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenth = Math.Sqrt((yb-ya)*(yb-ya)+(xb-xa)*(xb-xa)+(zb-za)*(zb-za));
    return lenth;
}

Console.Write("Введите координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double res = Lenth(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками АВ равняется {res}");

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Progr(int num)
{
    int start = 1;
    while (start <= num)
    {
        Console.WriteLine(start * start * start);
        start++;
    }
    return start;
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Progr(number);