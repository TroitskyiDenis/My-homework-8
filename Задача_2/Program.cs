// Задача 64: Задайте значение N. Напишите программу, 
//            которая выведет все натуральные числа в промежутке от N до 1.
//            Выполнить с помощью рекурсии.
//            N = 5 -> "5, 4, 3, 2, 1"
//            N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using static System.Console;
Clear();
int number(string name)
{
  Write(name);
  int result = Convert.ToInt32(ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = number("Введите натуральное число N: ");

WriteLine(NaturalNumber(n, 1));