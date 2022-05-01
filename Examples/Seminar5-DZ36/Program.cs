// Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] mass = new int [4];
for ( int i = 0; i < mass.Length; i++)
{
 mass[i] = new Random().Next(-10,100);
 Console.Write(mass[i] + " ");
}
 var odd = mass.Where((element, index) => index % 2 != 0);
 
Console.WriteLine("Нечётные позиции: {0}. Сумма: {1}.", odd.Count(), odd.Sum());