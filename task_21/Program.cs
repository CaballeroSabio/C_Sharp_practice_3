/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
 * между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.WriteLine("Hi, User!");

int firstX, firstY, firstZ, secondX, secondY, secondZ;

void PointCoordinates()
{
    Console.Write("Enter the X value of the first point: ");
    firstX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Y value of the first point: ");
    firstY = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Z value of the first point: ");
    firstZ = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the X value of the second point: ");
    secondX = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Y value of the second point: ");
    secondY = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the Z value of the second point: ");
    secondZ = Convert.ToInt32(Console.ReadLine());
}

PointCoordinates();

double GetDistance3D(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Round(Math.Sqrt((Math.Pow((bx - ax), 2)) + (Math.Pow((by - ay), 2)) + (Math.Pow((bz - az), 2))), 2, MidpointRounding.ToZero);
}

Console.WriteLine($"The distance is {GetDistance3D(firstX, firstY, firstZ, secondX, secondY, secondZ)}");
Console.WriteLine();


