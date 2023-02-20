/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/

string? number = Console.ReadLine();


if (number!.Length == 5)
{
    if (number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine("Палиндром!");
    }
    else Console.WriteLine("Не палиндром!");
}

else Console.WriteLine($"Введи пятизначное число");