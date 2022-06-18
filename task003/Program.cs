using System;
using static System.Console;

Clear();

Write("Введите четверть: ");
int q =int.Parse(ReadLine());

switch(q)
{
    case 1:
    {
        Writeline("x > 0, y > 0");
        break;
    }
    case 2:
    {
        Writeline("x < 0, y > 0");
        break;
    }
    case 3:
    {
        Writeline("x < 0, y < 0");
        break;
    }
    case 4:
    {
        Writeline("x > 0, y < 0");
        break;
    }
}