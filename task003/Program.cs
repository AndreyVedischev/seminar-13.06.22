using System;
using static System.Console;

Clear();

Write("Введите четверть: ");
int q =int.Parse(ReadLine());

switch(q)
{
    case 1:
    {
        WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0, y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0, y < 0");
        break;
    }
    default:
    {
        WriteLine("Такой четверти не существует");
        break;
    }
}