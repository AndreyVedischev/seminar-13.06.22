using System;
using static System.Console;

Clear();

WriteLine("Введите N: ");
int N = Convert.ToInt32(ReadLine());
WriteLine();
for(int i = 2; i <= N; i+=2)
{
    Write($"{i}, ");
}
