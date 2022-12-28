using System;
using System.Globalization;
Console.WriteLine("please enter start");

int start = int.Parse(Console.ReadLine());
Console.WriteLine("please enter end");

int end = int.Parse(Console.ReadLine());

bool prime = true;


for (int i = start; i < end; i++)
{
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {

            prime = false;
            break;
        }
    }
    if (prime == true)
    {
        Console.WriteLine(i);
    }
    else
    {
        prime = true;
    }
}