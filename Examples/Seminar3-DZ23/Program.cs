﻿// Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125

int n = 4;
int i = 1;
while (i <= n)
{
    Console.WriteLine(i*i*i);
    i++;
}
