//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

int DigitNum(int num)
{
    int first = num / 10;
    int second = first % 10;
    return second;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number<1000)
{    
    int res = DigitNum(number);
    Console.WriteLine($"Вторым числом трехзначного числа {number} является {res}");
}
else 
    Console.WriteLine("Число не соответствует трехзначному!");

//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Для вывода третьего символа любого числа, прошу наваяйте какое-нить число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (number>999)
{
    number = number/10;
    res = number%10;
}
if (number<=99)
    Console.WriteLine("Третьего числа не существует");
else 
    Console.WriteLine(res);

//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool Den(int num)
{
    if (num == 6 || num == 7)
        return true;
    else return false;
}
 
Console.Write("Введите день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool dn = Den(number);

if (number>7 || number<1)
    Console.WriteLine("Число не соответствует заданному диапазону!"); 
else if (dn==true)
    Console.WriteLine("Да, день выходной!");
else
    Console.WriteLine("Нет, не выходной");