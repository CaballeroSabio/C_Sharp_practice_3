/*Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/


Console.Clear();
int firstX, firstY, secondX, secondY;
Console.WriteLine("Введите координаты X первой точки: ");
firstX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X первой точки: ");
firstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X первой точки: ");
secondX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X первой точки: ");
secondY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(firstX, firstY, secondX, secondY));

double GetDistance(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay))), 2, MidpointRounding.ToZero);
}