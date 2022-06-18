using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int N = Convert.ToInt32(ReadLine());
WriteLine();

for(int i = 1; i <= N; i++)
{
    WriteLine(Math.Pow(i, 2));
}
WriteLine();