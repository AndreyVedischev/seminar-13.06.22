using System;
using static System.Console;

Clear();

Write("Введите четверть: ");
int A =int.Parse(ReadLine());

string x = "", y = "";

if(A == 1)
{
    x = "x+";
    y = "y+";
}
if(A == 2)
{
    x = "x-";
    y = "y+";
}
if(A == 3)
{
    x = "x-";
    y = "y-";
}
if(A == 4)
{
    x = "x+";
    y = "y-";
}
WriteLine($"абсцисса:{x}, ордината:{y}.");