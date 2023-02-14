/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

int ReadInt32(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int xA = ReadInt32("Введите координату X первой точки: ");
int yA = ReadInt32("Введите координату Y первой точки: ");
int zA = ReadInt32("Введите координату Z первой точки: ");
int xB = ReadInt32("Введите координату X второй точки: ");
int yB = ReadInt32("Введите координату Y второй точки: ");
int zB = ReadInt32("Введите координату Z второй точки: ");

int A = xB - xA;
int B = yB - yA;
int C = zA - zB;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
