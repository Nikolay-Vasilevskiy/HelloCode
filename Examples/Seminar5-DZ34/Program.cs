// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.[345, 897, 568, 234] -> 2

int [] mass = new int [4];
for ( int i = 0; i < mass.Length; i++)
{
 mass[i] = new Random().Next(100,1000);
 Console.Write(mass[i] + " ");
}

            int even;
            even = 0;
            for (int i = 0; i < mass.Length; i++)
                
            if (mass[i] % 2 == 0)
                        even++;
            
        Console.WriteLine($"Количество четных: {even}");
        Console.ReadKey();
