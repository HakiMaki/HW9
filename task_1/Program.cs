using System;
using static System.Console;

Clear();
Write("Введите M: ");
int n = int.Parse(ReadLine()!);
Write("Введите N: ");
int m = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(n, m));

string PrintNumbers(int start, int end)
{
    if (end == start)
    {
        Console.WriteLine(end);
        return start.ToString();
    }

    string s = PrintNumbers(start, end - 1) + ' ' + end.ToString();
    Console.WriteLine(s);
    return (s);
}