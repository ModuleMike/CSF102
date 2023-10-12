for (int i = 1; i <=100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
        continue;
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}