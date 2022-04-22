// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = 3;
int y1 = 6;
int z1 = 8;
int x2 = 2;
int y2 = 1;
int z2 = -7;

double lenght = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)+ Math.Pow(z1-z2,2));
System.Console.WriteLine(lenght);
