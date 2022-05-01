// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76

double R; // разность между максимальным и минимальным элементом
double [] mass = new double [4];
for ( int i = 0; i < mass.Length; i++)
{
 mass[i] = new Random().Next(0,100);
 Console.WriteLine(mass[i] + " ");
}
 double max = double.MinValue;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        // найден больший элемент
        max = mass[i];
    }
    
}
double min = double.MaxValue;
for (int i = 0; i < mass.Length; i++)
{
if (mass[i] < min)
    {
        // найден наименьший элемент
        min = mass[i];
    }
}
R = max - min;
Console.WriteLine($"Максимальный элемент массива:{max}");
Console.WriteLine($"Минимальный элемент массива:{min}");
Console.WriteLine($"Разность:{R}");