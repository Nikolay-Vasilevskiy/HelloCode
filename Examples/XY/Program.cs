int x, y;
x = new Random (). Next (-100, 100);
y = new Random (). Next (-100, 100);
System.Console.WriteLine($"x={x}, y ={y}");
if(x == 0| y == 0)
{
System.Console.WriteLine("Не принадлежит конкретной четверти");
}
else if(x > 0 & y > 0)
{
System.Console.WriteLine("Точка принадлежит 1-й плоскости");
}
else if(x > 0 & y < 0)
{
 System.Console.WriteLine("Точка принадлежит 2-й плоскости");   
}
else if(x < 0 & y < 0)
{
    System.Console.WriteLine("Точка принадлежит 3-й плоскости");
    }
    else if(x < 0 & y > 0)
    {
      System.Console.WriteLine("Точка принадлежит 4-й плоскости");  
    }
