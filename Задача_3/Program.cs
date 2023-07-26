﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Clear();
Write("Введите значение M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите значение N: ");
int n = Convert.ToInt32(ReadLine());

int akkerman(int m, int n)
{
if (m == 0) 
return n + 1;
else
 if (n == 0) 
 return akkerman(m-1, 1);
else 
return akkerman(m-1, akkerman(m, n-1));
}

Write($"Функция Аккермана -> {akkerman(m, n)} ");