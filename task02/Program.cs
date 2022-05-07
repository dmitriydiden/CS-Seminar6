// Задача №40 Напишите программу, кторая на вход принимает три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины
using System;
Console.Clear();

Console.Write("Введите длину стороны А - ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите длину стороны B - ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите длину стороны C - ");
int C = int.Parse(Console.ReadLine());
if ((A + B) < C || (A + C) < B || (B + C) < A) Console.WriteLine($"Треугольника со сторонами А={A}; B={B};C={C}; - не существует");
else Console.WriteLine($"Треугольника со сторонами А={A}; B={B};C={C}; - существует");