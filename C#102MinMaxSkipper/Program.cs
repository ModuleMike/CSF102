int init, condition, increment;

do
{
    Console.Write("Enter Loop Start: ");
    if (int.TryParse(Console.ReadLine(), out init));
    {
        break;
    }
    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter Loop Increment: ");
    if (int.TryParse(Console.ReadLine(), out increment));
    {
        break;
    }
    Console.WriteLine("That is not a valid int.");
} while (true);

do
{
    Console.Write("Enter Loop End: ");
    if (int.TryParse(Console.ReadLine(), out condition));
    {
        if (increment < 0 && condition < init)
        {
            break;
        }
        if (increment > 0 && condition > init)
        {
            break;
        }
    }
    Console.WriteLine("That is not a valid int.");
} while (true);

if (increment > 0)
{
    for (int i = init; i <= condition; i += increment)
    {
        Console.WriteLine(i);
    }
}
else if (increment < 0)
{
    for (int i = init; i >= condition; i += increment)
    {
        Console.WriteLine(i);
    }
}