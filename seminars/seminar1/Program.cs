﻿// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.WriteLine($"Quad of {num} is {quad}");
// Задача 2. Напишите программуб которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второва.

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if (quad == num2)
// {
//     Console.WriteLine("First number is quad of second number");
// }
// else
// {
//     Console.WriteLine("First number is not quad of second number");
// }

// Заача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает всецелыечисла в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while (current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }
// Задача 4. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8

// Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = num % 10;

// Console.WriteLine($"Last digit of {num} is {result}");
