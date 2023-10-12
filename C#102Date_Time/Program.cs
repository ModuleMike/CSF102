DateTime startDate = new DateTime();
DateTime endDate = new DateTime();
string frequency, skip;

do
{
    Console.Write("Enter Start Date: ");
    if (DateTime.TryParse(Console.ReadLine(), out startDate))
    {
        break;
    }
    Console.WriteLine("This is not a valid start date.");
} while (true);

Console.WriteLine($"{startDate:dddd MMM d, yyy}");
Console.WriteLine($"{startDate:dddd MMM dd, yyy}");

do
{
    Console.Write("Enter End Date: ");
    if (DateTime.TryParse(Console.ReadLine(), out endDate))
    {
        if (endDate > startDate)
        {
            break;
        }
        Console.WriteLine("End Date must be greater than start date.");
    }
    Console.WriteLine("This is not a valid end date.");

} while (true);

do
{
    Console.Write("Enter Frequency [ (D)aily, (W)eekly, (M)onthly, (Y)early]: ");
    frequency = Console.ReadLine().ToUpper();
    
    if (frequency == "D" || frequency == "W" || frequency == "M" || frequency == "Y")
    {
        break;
    }
    Console.WriteLine("This is not a valid Frequency selection. ");

} while (true);

do
{
    Console.Write("Skip Weekends (Y/N): ");
    skip = Console.ReadLine().ToUpper();
    if (skip == "Y" || skip == "N")
    {
        break;
    }
    Console.WriteLine("This is not a valid input to Skip Weekends.");
} while (true);

Console.WriteLine("Meeting Dates");
Console.WriteLine("=============");

if (frequency == "D")
{
    for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
    {
        if (skip == "Y")
        {
            if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                i = i.AddDays(1);
                continue;
            }
        }
        Console.WriteLine($"{i:dddd MMM d, yyy}");
        continue;
    }
}
else if (frequency == "W")
{
    for (DateTime i = startDate; i <= endDate; i = i.AddDays(7))
    {
        if (skip == "Y")
        {
            while ( i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                i = i.AddDays(1);
            }
            Console.WriteLine($"{i:dddd MMM d, yyy}");
            continue;
        }
        Console.WriteLine($"{i:dddd MMM d, yyy}");
        continue;
    }
}
else if (frequency == "M")
{
    for (DateTime i = startDate; i <= endDate; i = i.AddMonths(1)) 
    {
        if (skip == "Y")
        {
            while (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                i = i.AddDays(1);
            }
            Console.WriteLine($"{i:dddd MMM d, yyy}");
            continue;
        }
        Console.WriteLine($"{i:dddd MMM d, yyy}");
        continue;
    }
}
else if (frequency == "Y")
{
    for (DateTime i = startDate; i <= endDate; i = i.AddYears(1))
    {
        if (skip == "Y")
        {
            while (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
            {
                i = i.AddDays(1);
            }
            Console.WriteLine($"{i:dddd MMM d, yyy}");
            continue;
        }
        Console.WriteLine($"{i:dddd MMM d, yyy}");
        continue;
    }
}