// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNumber(string str)
{
    Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}

// пользователь вводит значения b1, k1, b2 и k2

double[] array = new double[4];
array[0] = EnterNumber("Введите значение b1");
array[1] = EnterNumber("Введите значение k1");
array[2] = EnterNumber("Введите значение b2");
array[3] = EnterNumber("Введите значение k2");

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double x = (array[2] - array[0]) / (array[1] - array[3]);
double y = ((array[2] - array[0]) / (array[1] - array[3])) * array[1] + array[0];

System.Console.WriteLine($"Точка перечесения двух прямых имеет координаты : ({x}, {y})");
