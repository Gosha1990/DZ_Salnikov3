// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//   значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double GetNumberConsole(string message)
{

    Console.Write(message);
    string value = Console.ReadLine();
    double number = Convert.ToDouble(value);



    return number;
}



double b1 = GetNumberConsole("Введите значение b1: ");
double k1 = GetNumberConsole("Введите значение k1: ");
double b2 = GetNumberConsole("Введите значение b2: ");
double k2 = GetNumberConsole("Введите значение k2: ");

double x = 0, y = 0;

if ((k1 != k2))
{

    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
else
{
    Console.WriteLine("Решение отсутствует");
}

Console.WriteLine($"Точка пересечения x = {x}; y = {y};");