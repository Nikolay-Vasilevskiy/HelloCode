System.Console.WriteLine("Введите номер четверти");
int num;
num = int.Parse(Console.ReadLine());
if(num == 1)
{
    System.Console.WriteLine("Диапозон возможных координат х: от 0 до бесконечности, y: от 0 до бесконечности");
    }
    else if (num == 2)
    {
    System.Console.WriteLine("Диапозон возможных координат х: от 0 до бесконечности, y: от -бесконечности до 0");
    }
    else if (num == 3)
   {
    System.Console.WriteLine("Диапозон возможных координат х: от -бесконечности до 0 , y: от -бесконечности до 0");   
   } 
   else if (num == 4)
   {
     System.Console.WriteLine("Диапозон возможных координат х: от -бесконечности до 0 , y: от 0 до бесконечности");   
   }
