﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехнчаное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;
if(Length == 3)
{
    int result = (number / 10) % 10;
    Console.WriteLine("Второе число: " + result);
}    
    else
    {
        Console.WriteLine("Число нетрезначное ");
    }


