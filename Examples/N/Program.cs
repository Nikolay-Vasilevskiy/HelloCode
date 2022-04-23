// Произведение чисел от одного до N( N=5-> 1*1,2*3,6*4,24*5)
Console.Clear();
System.Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
int x = 1;
for (int i = 1; i <= A; i ++)
{
    x *= i;
    System.Console.Write(x + " ");
}
