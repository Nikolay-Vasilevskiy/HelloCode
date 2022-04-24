// Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");

string day = Console.ReadLine();

if (day !="1" && day !="2" && day !="3" && day !="4" && day !="5" && day !="6" && day !="7")

Console.WriteLine("Нет такого дня недели!");

if (day == "1")
{
    System.Console.WriteLine ($"Понедельник"); 
}
if (day == "2")
{
    System.Console.WriteLine ($"Вторник"); 
}
if (day == "3")
{
    System.Console.WriteLine ($"Среда"); 
}
if (day == "4")
{
    System.Console.WriteLine ($"Четверг"); 
}
if (day == "5")
{
    System.Console.WriteLine ($"Пятница"); 
}
if (day == "6")
{
    System.Console.WriteLine ($"Суббота");
     System.Console.WriteLine ($"Выходной день");
}
if (day == "7")
{
    System.Console.WriteLine ($"Воскресение");
    System.Console.WriteLine ($"Выходной день");
}
