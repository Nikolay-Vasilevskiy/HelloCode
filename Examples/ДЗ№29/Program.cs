// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] mas = new int[8];
for (int i = 0; i < mas.Length; i++)
{
mas[i] = new Random().Next(0,10);
System.Console.Write(mas[i]);
}