
// ЗАДАЧА 1
// Напишите программу, которая на вход принимает два целых числа и проверяет, 
// является ли первое число квадратом второго
// а = 25, б = 5 => да
// а = 2, б = 10 => нет
// а = 9, б = -3 => да
// а = - 3, б = 9 => нет


// using System;

// public class Program
// {
// public static void Main()
// {
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
        
// if (IsPerfectSquare(num1, num2))
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} не является квадратом {num2}");
// }
// }

// public static bool IsPerfectSquare(int number, int numberToCheck)
// {
//     int squareRoot = (int) Math.Sqrt(number);

//     return squareRoot * squareRoot == number && numberToCheck % squareRoot == 0;
// }
// }


// ЗАДАЧА 2
// Напишите программу, которая на вход принимает целое число N, 
// а на входе показывает все целые числа в промежутке от -N до N

// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2



// Console.Write("Enter a number: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = -N; i <= N; i++)
// {
//     Console.Write(i + " ");
// }

// Console.ReadKey();

    



// ЗАДАЧА 3
// Напишите программу, которая принимает на вход трёхзначное целое число 
// и на выходе показывает сумму первой и последней цифры этого числа.

// int number = 456;
// int firstDigit = number / 100;
//     int lastDigit = number % 10;

//     int sum = firstDigit + lastDigit;

//     Console.WriteLine("Сумма первой и последней цифры: " + sum);

// Console.WriteLine("Hello, World!");
