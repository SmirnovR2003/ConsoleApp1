using LearnCSharp;
using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine(value: $"Вычисляет площадь и длину эллипса с полуосями A = {Сalculation.semiaxeA} и B = {Сalculation.semiaxeB}");

        Сalculation calculation = new Сalculation();
        int square = calculation.GetSquare();
        int length = calculation.GetLength();
        Console.WriteLine($"Площадь эллипса: {square}pi");
        Console.WriteLine($"Длина эллипса: {length}pi");

    }
}