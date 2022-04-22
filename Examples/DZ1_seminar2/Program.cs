// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int a = new Random().Next(100,1000);
int b = a / 100;
int c = a % 10;


System.Console.WriteLine($"случайное трёхзначное число {a}");
//System.Console.WriteLine($"число {b}");
//System.Console.WriteLine($"число {c}");

System.Console.WriteLine($"число без второй цифры {b}{c} ");
