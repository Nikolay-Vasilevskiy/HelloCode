// Вывести случайное число на отрезке (10,99) и показать наибольшую цифру числа
int a = new Random().Next(10,100);
System.Console.WriteLine($"случайное двухзначное число {a}");
int b = a / 10;
int c = a % 10;
if (b > c)
{
 System.Console.WriteLine ($" бОльшее число {b}");   
}
else
{
   System.Console.WriteLine ($" бОльшее число {c}"); 
}

