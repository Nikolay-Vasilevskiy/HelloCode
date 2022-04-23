// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
System.Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("A^B = " + Math.Pow(A, B)); 
