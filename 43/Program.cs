/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double b1 = ReadInt("Введите значение b1: ");
double k1 = ReadInt("Введите значение k1: ");
double b2 = ReadInt("Введите значение b2: ");
double k2 = ReadInt("Введите значение k2: ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");

double ReadInt(string text)
{
Console.WriteLine(text);
return Convert.ToDouble(Console.ReadLine());
}
