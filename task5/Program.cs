﻿// Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;

while(count <= n)
{
    Console.Write(count*count*count + " ");
    count++;
}