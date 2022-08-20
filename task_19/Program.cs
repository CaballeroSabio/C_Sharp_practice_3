/* Задача 19.
 * Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("Hi, User!");
Console.Write("Enter a five-digit number: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());

if (fiveDigitNumber >= 10000 && fiveDigitNumber < 100000)
{
    Palindrome (fiveDigitNumber);
}
else
{
    Console.WriteLine("This number is not five digits");
}

void Palindrome (int x)
{ 
    int a = x/10000;
    int b = x/1000%10;
    int d = x/10%10;
    int e = x%10;
    if (a == e && b == d) 
    {
        Console.WriteLine("This 5 digit number is a palindrome");
    }
    else
    {
        Console.WriteLine("This 5 digit number isn't a palindrome");
    }
}

Console.WriteLine("Goodbye, User!");
Console.WriteLine();


