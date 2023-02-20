/*Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.*/
Console.WriteLine($"Введите координаты первой точки через пробел: ");
var lst = Console.ReadLine()?.Split().Select(int.Parse).ToList();
int x1 = lst[0];
int y1 = lst[1];
int z1 = lst[2];

Console.WriteLine($"Введите координаты второй точки через пробел: ");

lst = Console.ReadLine()?.Split().Select(int.Parse).ToList();

int x2 = lst[0];
int y2 = lst[1];
int z2 = lst[2];
double result = Math.Sqrt(Math.Pow((x2-x1), 2) + 
                Math.Pow((y2-y1), 2) + 
                Math.Pow((z2-z1), 2));
Console.WriteLine(Math.Round(result, 2));
