using System;

Console.Write("Введите сторону 1:");
            int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите сторону 2:");
            int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите сторону 1:");
            int num3 = int.Parse(Console.ReadLine());
Console.WriteLine($"Периметр: {num1+num2+num3}");

double polyP = (num1+num2+num3)/2;
Console.WriteLine($"Площадь: {Math.Sqrt(polyP*(polyP-num1)*(polyP-num2)*(polyP-num3))}");