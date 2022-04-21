// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int a = new Random().Next(100,1000);
int b = a / 100;
int c = a % 10;


System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(c & b);

