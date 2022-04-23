// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.WriteLine("Введите число");
int size = int.Parse(Console.ReadLine());
    
int i;

    for (i = size == 0 ? 0 : 0; size > 0; size /= 10)
    {
        i += size %10; //i = i + size %10;
    }

System.Console.WriteLine(i);


