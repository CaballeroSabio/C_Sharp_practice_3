/* Задача 18.
 * Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();
Console.Write("Введите номер четверти: ");
string numberQuarter = Console.ReadLine();


string Quarter(string q)
{
    if (q == "1") return ("x > 0 и y > 0");
    if (q == "2") return ("x < 0 и y > 0");
    if (q == "3") return ("x < 0 и y < 0");
    if (q == "4") return ("x > 0 и y < 0");   
    return ("Подобной четверти не существует");
}

string result = Quarter(numberQuarter);
Console.WriteLine(result);
Console.WriteLine();