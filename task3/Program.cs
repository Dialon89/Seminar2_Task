﻿// Задача 3: Напишите программу,
// которая принимает на вход целое число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

Console.Clear();
Console. Write("Введите целое число из допустимого диапазона от 10 до 99: ");
int n = int.Parse(Console.ReadLine()!);
int max = 0;
if (n >= 10 && n <= 99)
{
        
            int n1 = n % 10;

            if (n1 > max)
            {
                max = n1;
            }

            n /= 10;

    Console.WriteLine("Наибольшая цифра в числе: " + max);
    
}
else
{
    Console.WriteLine("Ошибка: Введенное число не находится в допустимом диапазоне.");
}
