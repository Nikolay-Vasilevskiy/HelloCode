// Найти второе число из трехзачного числа
//int number = 456;
System.Console.WriteLine("Введите трёхзначное число number: ");
int number = int.Parse(Console.ReadLine());
number = number %100;
number = number /10;
System.Console.WriteLine(number);
