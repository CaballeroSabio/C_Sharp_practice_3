/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.WriteLine("Hi, User!");
Console.Write("Enter a number from 1 to infinity: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (n > 0)
{
    WriteSquareTable(n);
}
else
{
    Console.WriteLine("Wrong number entered!");
}


void WriteSquareTable(int n)
{
    int i = 1;
    
    while (i <= n)
    {
        Console.WriteLine($"| {i} | {i * i * i, 3} |");
        i++;
    }
}

Console.WriteLine("Goodbye, User!");
Console.WriteLine();
