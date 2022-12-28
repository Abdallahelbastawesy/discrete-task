int sum = 0;

Console.WriteLine("please enter the start num");

int start = int.Parse(Console.ReadLine());

Console.WriteLine("please enter the end num");

int end = int.Parse(Console.ReadLine());

for (int i = start; i < end; i++)
{
    for (int j = 1; i > j; j++)
    {
        if (i % j == 0)
        {
            sum = sum + j;
        }
    }
    if (sum == i)
    {
        Console.WriteLine(i);
    }
    sum = 0;

}






